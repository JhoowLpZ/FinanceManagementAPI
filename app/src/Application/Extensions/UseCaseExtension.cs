using Application.UseCases;
using Application.Interfaces.Inputs;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Extensions
{
    public static class UseCaseExtension
    {
        public static IServiceCollection RegisterUseCases(this IServiceCollection services)
        {
            services.AddScoped<IIncomeUseCase, IncomeUseCase>();
            services.AddScoped<IExpenseUseCase, ExpenseUseCase>();

            return services;
        }
    }
}
