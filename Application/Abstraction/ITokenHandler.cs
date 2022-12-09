using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction
{
    public interface ITokenHandler
    {
        Task<string> CreateAccessToken(Kullanici user, int minute = 5);
    }
}
