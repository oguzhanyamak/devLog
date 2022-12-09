using Application.Abstraction;
using Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserService _userService;
        readonly UserManager<Kullanici> _userManager;
        readonly SignInManager<Kullanici> _signInManager;
        private readonly ITokenHandler _tokenHandler;

        public AuthService(IUserService userService, UserManager<Kullanici> userManager, SignInManager<Kullanici> signInManager, ITokenHandler tokenHandler)
        {
            _userService = userService;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenHandler = tokenHandler;
        }

        public async Task<string> LoginAsync(string Email, string password, int accessTokenLifeTime = 60)
        {
            Kullanici kullanici = await _userManager.FindByEmailAsync(Email);
            string token = string.Empty;
            if(kullanici is null)
            {
                throw new Exception();
            }
            SignInResult result = await _signInManager.CheckPasswordSignInAsync(kullanici, password, false);
            if(result.Succeeded) {
                token = await _tokenHandler.CreateAccessToken(kullanici, accessTokenLifeTime);
                return token;
            }
            return "--";
        }
    }
}
