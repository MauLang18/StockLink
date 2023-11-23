using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StockLink.Application._6.Interfaces;
using StockLink.Application._6.Services;
using System.Reflection;

namespace StockLink.Application._6.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionApplications(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(configuration);

            /*services.AddFluentValidation(options =>
            {
                options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies().Where(p => !p.IsDynamic));
            });*/

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IUsuarioApplication, UsuarioApplication>();
            services.AddScoped<IAuthApplication, AuthApplication>();
            services.AddScoped<IRolApplication, RolApplication>();

            return services;
        }
    }
}
