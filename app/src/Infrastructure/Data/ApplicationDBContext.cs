using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories 
{    
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options) { }

        public DbSet<Expense> Expenses => Set<Expense>();
        public DbSet<Income> Incomes => Set<Income>();
    }
}