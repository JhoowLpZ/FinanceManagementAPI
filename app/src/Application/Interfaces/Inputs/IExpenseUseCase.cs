using Domain.Entities;

namespace Application.Interfaces.Inputs
{
    internal interface IExpenseUseCase
    {
        Task<IEnumerable<Expense>> GetExpenseListAsync();
        Task<Expense> GetExpenseByIdAsync(int Id);
        Task<Expense> InsertAsync(Expense expense);
        Task<bool> DeleteAsync(int Id);
    }
}
