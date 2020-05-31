﻿using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WorldExplorerEurope.API.Domain.Helpers;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.Test.Interfaces;

namespace WorldExplorerEurope.Test.Services
{
    public class UserService : IUserService
    {
        private string secret = "632a6cb7-4915-4e7e-8e36-6015843e2d61";

        public string GenerateToken(User user)
        {
            var jwtTokenHander = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Role),
                    new Claim("spotifydj", user.IsSpotifyDj.ToString().ToLower())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = jwtTokenHander.CreateToken(tokenDescriptor);
            return jwtTokenHander.WriteToken(token);
        }
    }
}
