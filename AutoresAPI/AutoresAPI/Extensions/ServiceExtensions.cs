using AutoresAPI.Core.Business;
using AutoresAPI.Core.Data;
using AutoresAPI.Data;
using AutoresAPI.Service;
using Microsoft.Extensions.DependencyInjection;

namespace AutoresAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ILibroService, LibroService>();
            services.AddTransient<IAutorService, AutorService>();
            services.AddTransient<IEditorialService, EditorialService>();

            return services;
        }
    }
}
