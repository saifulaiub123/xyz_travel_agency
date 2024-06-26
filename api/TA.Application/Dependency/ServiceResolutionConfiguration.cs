﻿using TA.Application.IService;
using TA.Application.Service;
using TA.Domain.IEntity;
using Microsoft.Extensions.DependencyInjection;

namespace TA.Application.Dependency
{
    public static class ServiceResolutionConfiguration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICurrentUser, CurrentUser>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
