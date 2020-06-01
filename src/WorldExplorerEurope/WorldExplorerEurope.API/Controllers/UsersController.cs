using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SpotifyAPI.Web.Models;
using WorldExplorerEurope.API.Controllers.Base;
using WorldExplorerEurope.API.Data;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Domain.Interfaces;
using WorldExplorerEurope.API.Domain.Models;
using WorldExplorerEurope.API.Domain.Services;
using WorldExplorerEurope.API.Helpers;

namespace WorldExplorerEurope.API.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/countries/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private IUserService _userService;
        private readonly WorldExplorerContext _context;

        public UsersController(IOptions<AppSettings> appSettings, IUserService userService, WorldExplorerContext context)
        {
            _userService = userService;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = _context.Users;
            var usersWithoutPasswords = new List<UserDto>();
            foreach (var user in users)
            {
                usersWithoutPasswords.Add(new UserDto { BirthDate = user.BirthDate, Email = user.Email, FirstName = user.FirstName, Id = Guid.Parse(user.Id), LastName = user.LastName, Nationality = user.Nationality, Password = "", Token = "" });
            }
            return Ok(usersWithoutPasswords);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var user = _context.Users.SingleOrDefault(m => m.Id == id.ToString());
            if(user == null)
            {
                return NotFound($"Cannot find user with id:{id}");
            }
               var newUser = new UserDto { BirthDate = user.BirthDate, Email = user.Email, FirstName = user.FirstName, Id = Guid.Parse(user.Id), LastName = user.LastName, Nationality = user.Nationality, Password = "", Token = "" };
            newUser.Token = _userService.GenerateToken(user);
            return Ok(newUser);
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> login([FromBody] UserLoginDto userLoginDto)
        {
            var users = _context.Users;
            var user = users.FirstOrDefault(m => m.Email == userLoginDto.Email);
            if (user == null)
            {
                return NotFound("User not found, enter valid credentials!!!");
            }
            if (string.IsNullOrEmpty(userLoginDto.Password) || string.IsNullOrWhiteSpace(userLoginDto.Password))
            {
                return BadRequest("Password Incorrect!!! Enter a valid password!!");
            }
            var passwordHasher = new PasswordHasher<User>();
            var verify = passwordHasher.VerifyHashedPassword(user, user.PasswordHash, userLoginDto.Password);
            if (verify.Equals(PasswordVerificationResult.Failed))
            {
                return BadRequest("Password Incorrect!!! Enter a valid password!!");
            }
            var userDto = new UserDto() { Id = Guid.Parse(user.Id), BirthDate = user.BirthDate, Email = user.Email, FirstName = user.FirstName, LastName = user.LastName, Nationality = user.Nationality, Password = ""};
            userDto.Token = _userService.GenerateToken(user);

            var AdminRole = _context.UserClaims.Any(m => m.UserId == user.Id && m.ClaimValue == "Admin");
            if (AdminRole == true) userDto.Role = "Admin";
            var dj = _context.UserClaims.Any(m => m.UserId == user.Id && m.ClaimType == "isSpotifyDj");
            if (dj == true) userDto.IsSpotifyDj = dj;

            return Ok(userDto);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> addUser([FromBody] UserDto userDto)
        {
            var existingUser = _context.Users.FirstOrDefault(m => m.Email == userDto.Email);
            if (existingUser != null)
            {
                return BadRequest("User already exists");
            }

            try
            {
                var hasher = new PasswordHasher<User>();
                var user = new User()
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = userDto.FirstName,
                    LastName = userDto.LastName,
                    Nationality = userDto.Nationality,
                    Email = userDto.Email,
                    BirthDate = userDto.BirthDate,
                    EmailConfirmed = true,
                };
                user.PasswordHash = hasher.HashPassword(user, userDto.Password);
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                _context.UserClaims.Add(new IdentityUserClaim<string>() { UserId = user.Id, ClaimType = "role", ClaimValue = "Visitor" });
                if (userDto.IsSpotifyDj == true) _context.UserClaims.Add(new IdentityUserClaim<string>() { UserId = user.Id, ClaimType = "isSpotifyDj", ClaimValue = "true" });
                await _context.SaveChangesAsync();
                userDto.Token = _userService.GenerateToken(user);
                return Ok(user);
            }
            catch
            {
                return BadRequest("User cannot be added");
            }
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllBasicUsers()
        {
            var users = _context.Users;
            List<UserBasicDto> basicUsers = new List<UserBasicDto>();
            foreach (var user in users)
            {
                basicUsers.Add(new UserBasicDto
                {
                    Id = Guid.Parse(user.Id),
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Nationality = user.Nationality,
                    BirthDate = user.BirthDate
                });
            }

            return Ok(basicUsers);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute]Guid id)
        {
            var AdminRole = User.Claims.Any(m => m.Value == "Admin");
            if (AdminRole == false) return StatusCode(403);
            try
            {
                var user = _context.Users.SingleOrDefault(m => m.Id == id.ToString());
                if (user == null)
                {
                    return NotFound("User not found.");
                }
                var entity = _context.Remove(user);
                if (entity == null)
                {
                    return BadRequest("Cannot delete user.");
                }
                await _context.SaveChangesAsync();
                var claims = _context.UserClaims.Where(m => m.UserId == id.ToString());
                foreach(var claim in claims)
                {
                    _context.UserClaims.Remove(claim);
                }
                await _context.SaveChangesAsync();
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateUser([FromBody]UserDto userDto, [FromRoute]string id)
        {
            var AdminRole = User.Claims.Any(m => m.Value == "Admin");
            if (AdminRole == false) return StatusCode(403);
            try
            {
                if (userDto.Id != Guid.Parse(id))
                {
                    return BadRequest($"Id's are not the same. Dto id: {userDto.Id} & id: {id}");
                }
                var user = _context.Users.SingleOrDefault(m => m.Id == id);
                if (user == null)
                {
                    return NotFound("User not found.");
                }
                user.FirstName = userDto.FirstName;
                user.LastName = userDto.LastName;
                user.Nationality = userDto.Nationality;
                user.BirthDate = userDto.BirthDate;
                var newUser = _context.Update(user);
                if (newUser == null)
                {
                    return BadRequest("Cannot update user.");
                }
                await _context.SaveChangesAsync();
                var claims = _context.UserClaims.Where(m => m.UserId == id.ToString());
                foreach (var claim in claims)
                {
                    _context.UserClaims.Remove(claim);
                }
                await _context.SaveChangesAsync();
                if (userDto.IsSpotifyDj == true) _context.UserClaims.Add(new IdentityUserClaim<string>() { UserId = user.Id, ClaimType = "isSpotifyDj", ClaimValue = "true" });
                if (userDto.Role == "Admin") _context.UserClaims.Add(new IdentityUserClaim<string>() { UserId = user.Id, ClaimType = "role", ClaimValue = userDto.Role });
                else _context.UserClaims.Add(new IdentityUserClaim<string>() { UserId = user.Id, ClaimType = "role", ClaimValue = "Visitor" });
                await _context.SaveChangesAsync();
                return Ok(userDto);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}