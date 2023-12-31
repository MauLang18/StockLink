﻿using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using StockLink.Application.Interface.Interfaces;
using StockLink.Application.UseCase.Commons.Behaviours;
using StockLink.Application.UseCase.UseCase.Mail.Commands.SendEmailCommand;
using System.Reflection;

namespace StockLink.Application.UseCase.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionApplication(this IServiceCollection services)
        {
            services.AddMediatR(x => x.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            services.AddScoped<ISendEmailRepository, SendEmailServices>();

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

            return services;
        }
    }
}
