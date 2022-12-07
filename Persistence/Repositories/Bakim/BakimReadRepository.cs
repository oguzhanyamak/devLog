using Application.Context;
using Application.Repositories.Bakim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Bakim
{
    public class BakimReadRepository : ReadRepository<Core.Entities.BakimBilgisi>, IBakimReadRepository
    {
        public BakimReadRepository(devLogContext context) : base(context)
        {
        }
    }
}
