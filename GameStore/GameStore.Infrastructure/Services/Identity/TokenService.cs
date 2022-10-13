using GameStore.Application.Contracts.Services.Identity;
using GameStore.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Infrastructure.Services.Identity
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _config;
        private readonly UserManager<User> _userManager;

        public TokenService(IConfiguration config,
                            UserManager<User> userManager)
        {
            _config = config;
            _userManager = userManager;
        }

        public async Task<string> GetTokenAsync(User user)
        {
            var tokenDescriptor = new JwtSecurityToken(
                issuer: _config["JwtSettings:Issuer"],
                audience: _config["JwtSettings:Audience"],
                claims: await GetClaims(user),
                expires: DateTime.Now.AddDays(double.Parse(_config["JwtSettings:ExpirationTimeInDays"])),
                signingCredentials: GetSigningCredentials());

            var tokenHandler = new JwtSecurityTokenHandler();            
            return tokenHandler.WriteToken(tokenDescriptor);
        }

        private SigningCredentials GetSigningCredentials() 
        {
            var key = Encoding.UTF8.GetBytes(_config["JwtSettings:Key"]);
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private async Task<List<Claim>> GetClaims(User user) 
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName)
            };

            foreach (var role in await _userManager.GetRolesAsync(user))
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }
    }
}
