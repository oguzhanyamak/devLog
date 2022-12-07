using Application.Context;
using Application.Repositories.Bakim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Bakim
{
    public class BakimWriteRepository : WriteRepository<Core.Entities.BakimBilgisi>, IBakimWriteRepository
    {
        public BakimWriteRepository(devLogContext context) : base(context)
        {
        }
    }
}
