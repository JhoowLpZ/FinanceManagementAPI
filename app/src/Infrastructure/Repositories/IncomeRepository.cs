using Application.Interfaces.Outputs;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class IncomeRepository : IRepository<Income>
    {
        private readonly ApplicationDBContext _context;

        public IncomeRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public virtual async Task<IEnumerable<Income>> GetAll()
        {
            return await _context.Set<Income>().ToListAsync();
        }

        public async Task<Income> GetById(object id)
        {
            return await _context.Set<Income>().FindAsync(id);
        }

        public async Task<Income> SaveAsync(Income entity)
        {
            await _context.Set<Income>().AddAsync(entity);
            return entity;
        }

        public Task UpdateAsync(Income entity)
        {
            Income exist = _context.Set<Income>().Find(entity.Id);
            _context.Entry(exist).CurrentValues.SetValues(entity);
            return Task.CompletedTask;
        }

        public async Task<bool> DeleteAsync(object id)
        {
            var entity = await _context.Set<Income>().FindAsync(id);
            if (entity == null)
                return false;

            _context.Set<Income>().Remove(entity);
            return true;
        }
    }
}
