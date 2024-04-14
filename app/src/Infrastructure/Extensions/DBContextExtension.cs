using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions
{
    public static class DBContextExtension
    {
        public static IServiceCollection RegisterDbContext(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDBContext>(opt => opt.UseInMemoryDatabase("Expense"));

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }
    }
}
