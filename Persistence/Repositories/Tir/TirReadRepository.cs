using Application.Context;
using Application.Repositories.Tir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Tir
{
    public class TirReadRepository : ReadRepository<Core.Entities.Tir>, ITirReadRepository
    {
        private readonly devLogContext _context;
        public TirReadRepository(devLogContext context) : base(context)
        {
            _context = context;
        }

        public Core.Entities.Tir GetByPlaka(string plaka)
        {
            return _context.Tirlar.Where(x => x.Plaka == plaka).FirstOrDefault();
        }
    }
}

