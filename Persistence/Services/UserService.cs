using Application.Abstraction;
using Application.Features.Commands.AppUser.CreateUser;
using Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class UserService : IUserService
    {
        readonly UserManager<Kullanici> _userManager;

        public UserService(UserManager<Kullanici> userManager)
        {
            _userManager = userManager;
        }
        public async Task<CreateUserCommandResponse> CreateAsync(CreateUserCommandRequest model)
        {
            IdentityResult result = await _userManager.CreateAsync(new()
            {
                Id = Guid.NewGuid().ToString(),
                Email = model.email,
                UserName = model.email,

            },model.password);

            CreateUserCommandResponse response = new() { Succeeded = result.Succeeded };

            if (result.Succeeded)
                response.Message = "Kullanıcı başarıyla oluşturulmuştur.";
            else
                foreach (var error in result.Errors)
                    response.Message += $"{error.Code} - {error.Description}\n";
            return response;
        }
    }
}
