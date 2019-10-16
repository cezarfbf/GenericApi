using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DefaultDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("GenericApiDatabase")));

            services.AddScoped<IDefaultDbContext>(provider => provider.GetService<DefaultDbContext>());

            return services;
        }
    }
}
