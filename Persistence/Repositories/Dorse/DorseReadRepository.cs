using Application.Context;
using Application.Repositories.Dorse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Dorse
{
    public class DorseReadRepository : ReadRepository<Core.Entities.Dorse>, IDorseReadRepository
    {
        public DorseReadRepository(devLogContext context) : base(context)
        {
        }
    }
}
