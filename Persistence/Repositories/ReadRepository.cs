using Application.Context;
using Application.Repositories;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly devLogContext _context;
        public DbSet<T> Table => _context.Set<T>();

        public ReadRepository(devLogContext context)
        {
            _context = context;
        }

        public IQueryable<T> GelAll()
        {
            return Table.AsQueryable();
        }

        public Task<T> GetByIdAsync(string id)
        {
            return Table.AsQueryable().FirstOrDefaultAsync(data => data.Id == id);
        }

        public Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
        {
            return Table.AsQueryable().FirstOrDefaultAsync(method);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        {
            return Table.Where(method);
        }
    }
}
