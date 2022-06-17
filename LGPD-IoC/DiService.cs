using LGPD_BLL.Infra.Services.Interfaces;
using LGPD_BLL.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGPD_IoC
{
    public static class DiService
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioService, UsuarioService>();

            return services;
        }

    }
}
