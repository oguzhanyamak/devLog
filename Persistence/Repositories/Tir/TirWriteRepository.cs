using Application.Context;
using Application.Repositories.Tir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Tir
{
    public class TirWriteRepository : WriteRepository<Core.Entities.Tir>, ITirWriteRepository
    {
        public TirWriteRepository(devLogContext context) : base(context)
        {
        }
    }
}
