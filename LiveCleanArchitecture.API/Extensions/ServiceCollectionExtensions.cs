using LiveCleanArchitecture.Application.Services;
using LiveCleanArchitecture.Core.Interfaces.Repositories;
using LiveCleanArchitecture.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace LiveCleanArchitecture.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
