using Application.Abstraction;
using Application.Context;
using Application.Repositories.Bakim;
using Application.Repositories.Dorse;
using Application.Repositories.Tir;
using Application.Repositories.Yuk;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories.Bakim;
using Persistence.Repositories.Dorse;
using Persistence.Repositories.Tir;
using Persistence.Repositories.Yuk;
using Persistence.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Extension
{
    public static class ServiceRegistiration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddDbContext<devLogContext>(options => options.UseSqlServer("Server=localhost;Database=devLog;User Id=sa;Password=Password1;"));
            services.AddIdentity<Kullanici, Role>().AddEntityFrameworkStores<devLogContext>();
            services.AddScoped<ITirReadRepository, TirReadRepository>();
            services.AddScoped<ITirWriteRepository, TirWriteRepository>();

            services.AddScoped<IDorseReadRepository, DorseReadRepository>();
            services.AddScoped<IDorseWriteRepository, DorseWriteRepository>();

            services.AddScoped<IYukReadRepository, YukReadRepository>();
            services.AddScoped<IYukWriteRepository, YukWriteRepository>(); 

            services.AddScoped<IBakimReadRepository, BakimReadRepository>();
            services.AddScoped<IBakimWriteRepository, BakimWriteRepository>();


        }
    }
}
