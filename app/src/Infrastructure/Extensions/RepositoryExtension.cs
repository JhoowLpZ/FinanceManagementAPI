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
            services.AddTransient<IRepository<Income>, IncomeRepository>();
            services.AddTransient<IRepository<Expense>, ExpenseRepository>();

            return services;
        }
    }
}
