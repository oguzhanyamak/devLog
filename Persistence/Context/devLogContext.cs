using Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.Context
{
    public class devLogContext : IdentityDbContext<Kullanici,Role,string>
    {
        public devLogContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BakimBilgisi> BakimBilgileri { get; set; }
        public DbSet<Dorse> Dorseler { get; set; }
        public DbSet<Tir> Tirlar { get; set; }
        public DbSet<Yuk> Yukler { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("Server=localhost;Database=devLog;User Id=sa;Password=Password1;");
        }
    }
}
