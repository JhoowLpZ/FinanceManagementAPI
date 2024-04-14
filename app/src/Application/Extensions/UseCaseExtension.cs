using Application.UseCases;
using Application.Interfaces.Inputs;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Extensions
{
    public static class UseCaseExtension
    {
        public static IServiceCollection RegisterUseCases(this IServiceCollection services)
        {
            services.AddTransient<IIncomeUseCase, IncomeUseCase>();
            services.AddTransient<IExpenseUseCase, ExpenseUseCase>();

            return services;
        }
    }
}
