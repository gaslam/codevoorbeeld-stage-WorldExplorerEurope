using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WorldExplorerEurope.API.Controllers.Base;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Domain.Interfaces;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Controllers
{
    [Route("api/countries/[controller]")]
    [ApiController]
    public class UsersController : ControllerDtoCrudBase<UserDto, IMappingRepository<UserDto>>
    {
        private readonly IMappingRepository<UserDto> _userMappingRepo;

        public UsersController(IMappingRepository<UserDto> userMappingRepo) : base(userMappingRepo)
        {
            _userMappingRepo = userMappingRepo;
        }

        [HttpPost("login")]
        public async Task<IActionResult> login([FromBody]UserDto userDto)
        {
            var users = _userMappingRepo.GetAll();
            var user = users.FirstOrDefault(m => m.Email == userDto.Email);
            if (user == null)
            {
                return NotFound("User not found, enter valid credentials!!!");
            }
            var passwordHasher = new PasswordHasher<UserDto>();
            if (passwordHasher.VerifyHashedPassword(userDto, user.Password, userDto.Password) == PasswordVerificationResult.Failed)
            {
                return BadRequest("Password Incorrect!!");
            }
            return Ok(userDto);
        }

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