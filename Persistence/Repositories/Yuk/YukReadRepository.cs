using Application.Context;
using Application.Repositories.Yuk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Yuk
{
    public class YukReadRepository : ReadRepository<Core.Entities.Yuk>, IYukReadRepository
    {
        public YukReadRepository(devLogContext context) : base(context)
        {
        }
    }
}
