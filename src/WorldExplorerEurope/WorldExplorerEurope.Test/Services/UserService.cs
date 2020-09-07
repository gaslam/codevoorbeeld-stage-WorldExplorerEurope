using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WorldExplorerEurope.API.Domain.Helpers;
using WorldExplorerEurope.API.Domain.Models;
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
                    new Claim(ClaimTypes.Role, "Admin"),
                    new Claim("spotifydj", "true")
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = jwtTokenHander.CreateToken(tokenDescriptor);
            return jwtTokenHander.WriteToken(token);
        }

        public string GenerateTokenApp(WorldExplorerEurope.App.Domain.Models.User user)
        {
            var jwtTokenHander = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[0]),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            
            if(user.Role == "Admin")
            {
                IdentityUserClaim<string> claim = new IdentityUserClaim<string>() { ClaimType = "role", ClaimValue = user.Role, UserId = user.Id.ToString() };
                tokenDescriptor.Subject.AddClaim(new Claim(claim.ClaimType, claim.ClaimValue));
            }
            else
            {
                IdentityUserClaim<string> claim = new IdentityUserClaim<string>() { ClaimType = "role", ClaimValue = user.Role, UserId = user.Id.ToString() };
                tokenDescriptor.Subject.AddClaim(new Claim(claim.ClaimType, claim.ClaimValue));
            }

            if(user.IsSpotifyDj == true)
            {
                IdentityUserClaim<string> claim = new IdentityUserClaim<string>() { ClaimType = "isSpotifyDJ", ClaimValue = "true", UserId = user.Id.ToString() };
                tokenDescriptor.Subject.AddClaim(new Claim(claim.ClaimType, claim.ClaimValue));
            }

            var token = jwtTokenHander.CreateToken(tokenDescriptor);
            return jwtTokenHander.WriteToken(token);
        }
    }
}
