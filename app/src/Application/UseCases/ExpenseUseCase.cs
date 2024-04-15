using Application.Interfaces.Inputs;
using Application.Interfaces.Outputs;
using Domain.Entities;

namespace Application.UseCases
{
    public class ExpenseUseCase : IExpenseUseCase
    {
        private readonly IRepository<Expense> _repository;
        public ExpenseUseCase(IRepository<Expense> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Expense>> GetExpenseListAsync()
        {
            try
            {
                return await _repository.GetAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<Expense> GetExpenseByIdAsync(int id)
        {
            try
            {
                return await _repository.GetById(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<Expense> InsertAsync(Expense expense)
        {
            try
            {
                return await _repository.SaveAsync(expense);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<Expense> UpdateAsync(Expense expense, int id)
        {
            try
            {
                return await _repository.UpdateAsync(expense, id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                return await _repository.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
