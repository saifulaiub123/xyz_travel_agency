using Microsoft.Extensions.DependencyInjection;
using TA.Domain.IRepository;
using TA.Infrastructure.Repository;

namespace TA.Infrastructure.Dependency
{
    public static class RepositoryResolutionConfiguration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IOtpRepository, OtpRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            return services;
        }
    }
}
