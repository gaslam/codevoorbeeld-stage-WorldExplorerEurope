using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using WorldExplorerEurope.API.Data;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Domain.Helpers;
using WorldExplorerEurope.API.Domain.Interfaces;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Services
{
    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;

        private WorldExplorerContext _context;

        public UserService(IOptions<AppSettings> appSettings, WorldExplorerContext context)
        {
            _appSettings = appSettings.Value;
            _context = context;
        }

        public string GenerateToken(User user)
        {
            var jwtTokenHander = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            IEnumerable<IdentityUserClaim<string>> claims = _context.UserClaims
            .Where(uc => uc.UserId == user.Id);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[0]),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            foreach(IdentityUserClaim<string>claim in claims)
            {
                Claim newClaim = new Claim(claim.ClaimType, claim.ClaimValue);
                tokenDescriptor.Subject.AddClaim(newClaim);
            }

            var token = jwtTokenHander.CreateToken(tokenDescriptor);
            return jwtTokenHander.WriteToken(token);
        }
    }
}
