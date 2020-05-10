using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using WorldExplorerEurope.API.Controllers.Base;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Domain.Interfaces;
using WorldExplorerEurope.API.Domain.Models;
using WorldExplorerEurope.API.Domain.Services;
using WorldExplorerEurope.API.Helpers;

namespace WorldExplorerEurope.API.Controllers
{
    [Authorize]
    [Route("api/countries/[controller]")]
    [ApiController]
    public class UsersController : ControllerDtoCrudBase<UserDto, IMappingRepository<UserDto>>
    {
        private readonly IMappingRepository<UserDto> _userMappingRepo;

        private IUserService _userService;

        public UsersController(IMappingRepository<UserDto> userMappingRepo, IOptions<AppSettings> appSettings, IUserService userService) : base(userMappingRepo)
        {
            _userMappingRepo = userMappingRepo;
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> login([FromBody]UserLoginDto userLoginDto)
        {
            var users = _userMappingRepo.GetAll();
            var user = users.FirstOrDefault(m => m.Email == userLoginDto.Email);
            if (user == null)
            {
                return NotFound("User not found, enter valid credentials!!!");
            }
            var passwordHasher = new PasswordHasher<UserDto>();
            var verify = passwordHasher.VerifyHashedPassword(user, user.Password, userLoginDto.Password);
            if (verify.Equals(PasswordVerificationResult.Failed))
            {
                return BadRequest("Password Incorrect!!");
            }
            user.Token = _userService.GenerateToken(user);
            return Ok(user);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> addUser([FromBody]UserDto user)
        {
            var existingUser = _userMappingRepo.GetAll().FirstOrDefault(m => m.Email == user.Email);
            if (existingUser != null)
            {
                return BadRequest("User already exists");
            }

            try
            {
                var hasher = new PasswordHasher<UserDto>();
                user.Password = hasher.HashPassword(user, user.Password);
                await _userMappingRepo.Add(user);
                user.Token = _userService.GenerateToken(user);
                return Ok(user);
            }
            catch
            {
                return BadRequest("User cannot be added");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("all")]
        public async Task<IActionResult> GetAllBasicUsers()
        {
            var users = _userMappingRepo.GetAll();
            List<UserBasicDto> basicUsers = new List<UserBasicDto>();
            foreach (var user in users)
            {
                basicUsers.Add(new UserBasicDto
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Nationality = user.Nationality,
                    BirthDate = user.BirthDate
                });
            }

            return Ok(basicUsers);
        }
    }
}