using Application.Abstraction;
using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class TokenHandler : ITokenHandler
    {
        readonly IConfiguration _configuration;
        readonly UserManager<Kullanici> _userManager;

        public TokenHandler(IConfiguration configuration, UserManager<Kullanici> userManager)
        {
            _configuration = configuration;
            _userManager = userManager;
        }
        public async Task<string> CreateAccessToken(Kullanici user, int minute = 60)
        {
            Kullanici kullanici = await _userManager.FindByEmailAsync(user.Email);
            var role = await _userManager.GetRolesAsync(user);
            SymmetricSecurityKey security = new(Encoding.UTF8.GetBytes(_configuration["Token:SecurityKey"]));
            SigningCredentials singingCredentials = new(security, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken securitytoken = new(audience: _configuration["Token:Audience"],
                issuer: _configuration["Token:Issuer"],
                expires: DateTime.UtcNow.AddMinutes(minute),
                notBefore: DateTime.UtcNow,
                signingCredentials: singingCredentials,
                claims: new List<Claim> { new(ClaimTypes.Email, user.Email), new(ClaimTypes.Role, role[0].ToString()) });
            JwtSecurityTokenHandler tokenHandler = new();
            string token = tokenHandler.WriteToken(securitytoken);
            return token;
        }
    }
}
