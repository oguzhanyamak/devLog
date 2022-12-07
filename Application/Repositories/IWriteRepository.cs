using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IWriteRepository<T> where T:BaseEntity
    {
        Task<bool> AddAsync(T Model);
        bool Remove(T Model);
        bool Update(T Model);
        Task<int> SaveAsync();

    }
}
