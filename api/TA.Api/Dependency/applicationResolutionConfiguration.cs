using TA.Api.Authentication;
using TA.Application.IService;
using TA.Application.Service;
using TA.Domain.IRepository;
using TA.Infrastructure.Repository;

namespace TA.Api.Dependency
{
    public static class ApplicationResolutionConfiguration
    {
        public static IServiceCollection ApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<TokenHelper>();
            services.AddScoped<ISuggessionService, SuggessionService>();

            return services;
        }
    }
}
