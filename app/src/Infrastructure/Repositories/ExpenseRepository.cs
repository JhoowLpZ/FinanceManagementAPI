using Application.Interfaces.Outputs;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ExpenseRepository : IRepository<Expense>
    {
        private readonly ApplicationDBContext _context;

        public ExpenseRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public virtual async Task<IEnumerable<Expense>> GetAll()
        {
            return await _context.Set<Expense>().ToListAsync();
        }

        public async Task<Expense> GetById(object id)
        {
            return await _context.Set<Expense>().FindAsync(id);
        }

        public async Task<Expense> SaveAsync(Expense entity)
        {
            await _context.Set<Expense>().AddAsync(entity);
            await _context.SaveChangesAsync();
            
            return entity;
        }

        public async Task<Expense> UpdateAsync(Expense entity, object id)
        {
            Expense exist = await _context.Set<Expense>().FindAsync(id);
            _context.Entry(exist).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> DeleteAsync(object id)
        {
            var entity = await _context.Set<Expense>().FindAsync(id);
            if (entity == null)
                return false;

            _context.Set<Expense>().Remove(entity);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
