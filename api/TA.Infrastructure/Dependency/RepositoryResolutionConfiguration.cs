using Microsoft.Extensions.DependencyInjection;
using TA.Domain.IRepository;
using TA.Infrastructure.Repository;

namespace TA.Infrastructure.Dependency
{
    public static class RepositoryResolutionConfiguration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
 
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
