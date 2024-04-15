using Application.Interfaces.Inputs;
using Application.Interfaces.Outputs;
using Domain.Entities;

namespace Application.UseCases
{
    public class IncomeUseCase : IIncomeUseCase
    {
        private readonly IRepository<Income> _repository;
        public IncomeUseCase(IRepository<Income> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Income>> GetIncomeListAsync()
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

        public async Task<Income> GetIncomeByIdAsync(int id)
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

        public async Task<Income> InsertAsync(Income income)
        {
            try
            {
                return await _repository.SaveAsync(income);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<Income> UpdateAsync(Income income, int id)
        {
            try
            {
                return await _repository.UpdateAsync(income, id);
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
