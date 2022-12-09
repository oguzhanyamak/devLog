using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Extension
{
    public static class ServiceRegistiration
    {

        public static void ApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ServiceRegistiration));
        }
    }
}
