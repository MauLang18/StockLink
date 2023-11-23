using Microsoft.Extensions.DependencyInjection;
using StockLink.Application.Interface.Interface;
using StockLink.Persistence.Context;
using StockLink.Persistence.Repositories;

namespace StockLink.Persistence.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionPersistence(this IServiceCollection services)
        {
            services.AddSingleton<ApplicationDbContext>();

            services.AddScoped<IArticuloRepository, ArticuloRepository>();
            services.AddScoped<IFamiliasRepository, FamiliasRepository>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
