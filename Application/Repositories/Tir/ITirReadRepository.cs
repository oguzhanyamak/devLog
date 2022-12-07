using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Tir
{
    public interface ITirReadRepository : IReadRepository<Core.Entities.Tir>
    {
        Core.Entities.Tir GetByPlaka(string plaka);
    }
}
