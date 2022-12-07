using Application.Context;
using Application.Repositories.Yuk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Yuk
{
    public class YukWriteRepository : WriteRepository<Core.Entities.Yuk>, IYukWriteRepository
    {
        public YukWriteRepository(devLogContext context) : base(context)
        {
        }
    }
}
