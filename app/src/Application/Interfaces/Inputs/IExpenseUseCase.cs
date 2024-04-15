using Domain.Entities;

namespace Application.Interfaces.Inputs
{
    public interface IExpenseUseCase
    {
        Task<IEnumerable<Expense>> GetExpenseListAsync();
        Task<Expense> GetExpenseByIdAsync(int id);
        Task<Expense> InsertAsync(Expense expense);
        Task<Expense> UpdateAsync(Expense expense, int id);
        Task<bool> DeleteAsync(int id);
    }
}
