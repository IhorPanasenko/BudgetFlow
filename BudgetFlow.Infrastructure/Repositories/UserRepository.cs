using BudgetFlow.Domain.Entities;
using BudgetFlow.Domain.Repositories;
using BudgetFlow.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BudgetFlow.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<bool> ExistsByEmailAsync(string email)
        {
            return await _context.Users.AnyAsync(u => u.Email == email);
        }

        public async Task<User?> GetByEmailAsync(string email)
            => await _dbSet.FirstOrDefaultAsync(u => u.Email == email);
    }   
}
