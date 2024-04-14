using Domain.Entities;
using Application.Interfaces.Outputs;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions
{
    public static class RepositoryExtension
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Income>, IncomeRepository>();
            services.AddScoped<IRepository<Expense>, ExpenseRepository>();

            return services;
        }
    }
}
