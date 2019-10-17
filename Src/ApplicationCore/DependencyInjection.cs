using ApplicationCore.Persistence;
using ApplicationCore.Repositories.Implementations;
using ApplicationCore.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace ApplicationCore
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationCore(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DefaultDbContext>(options =>
                            options.UseSqlServer(configuration.GetConnectionString("GenericApiDatabase")));

            services.AddScoped<IDefaultDbContext>(provider => provider.GetService<DefaultDbContext>());

            services.AddScoped<IProductRepository>(provider => provider.GetService<ProductRepository>());

            return services;
        }
    }
}
