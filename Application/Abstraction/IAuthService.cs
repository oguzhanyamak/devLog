using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction
{
    public interface IAuthService
    {
        Task<string> LoginAsync(string Email, string password, int accessTokenLifeTime=60);
    }
}
