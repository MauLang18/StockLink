using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StockLink.Infrastructure._6.Persistences.Contexts;
using StockLink.Infrastructure._6.Persistences.Interfaces;
using StockLink.Infrastructure._6.Persistences.Repository;

namespace StockLink.Infrastructure._6.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(USUARIOSContext).Assembly.FullName;

            services.AddDbContext<USUARIOSContext>(
                options => options.UseSqlServer(
                       configuration.GetConnectionString("Connection2"), b => b.MigrationsAssembly(assembly)), ServiceLifetime.Transient);

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }
    }
}
