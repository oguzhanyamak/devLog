using Application.Features.Commands.AppUser.CreateUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction
{
    public interface IUserService
    {
        Task<CreateUserCommandResponse> CreateAsync(CreateUserCommandRequest model);

        //Task<bool> UpdateRefreshToken(string refreshtoken, AppUser user, DateTime accessTokenDate, int addOnAccessTokenDate);
    }
}
