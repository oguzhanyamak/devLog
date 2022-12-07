using Application.Context;
using Application.Repositories;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly devLogContext _context;

        public WriteRepository(devLogContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();
        public async Task<bool> AddAsync(T Model)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(Model);
            return entityEntry.State == EntityState.Added;
        }

        public  bool Remove(T Model)
        {
            EntityEntry<T> entityEntry = Table.Remove(Model);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public bool Update(T Model)
        {
            EntityEntry entityEntry = Table.Update(Model);
            return entityEntry.State == EntityState.Modified;
        }
    }
}
