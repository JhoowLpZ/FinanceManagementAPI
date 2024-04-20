using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions
{
    public static class DBContextExtension
    {
        public static IServiceCollection RegisterDbContext(this IServiceCollection services, ConfigurationManager config)
        {
            string connectionStr = config.GetSection("ConnectionStrings")["SqlConnection"];

            services.AddDbContext<ApplicationDBContext>(opt => opt.UseMySql(connectionStr, ServerVersion.AutoDetect(connectionStr)));

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }
    }
}
