using BudgetFlow.Application.Database;
using BudgetFlow.Domain.Entities;
using BudgetFlow.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BudgetFlow.Infrastructure.Repositories
{
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        private readonly IApplicationDbContext _context;

        public TransactionRepository(IApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Transaction>> GetByUserIdAsync(Guid userId)
        {
            return await _context.Transactions
                .Where(t => t.UserId == userId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Transaction>> GetByHouseholdIdAsync(Guid householdId)
        {
            return await _context.Transactions
                .Where(t => t.Account.HouseholdId == householdId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Transaction>> GetByAccountIdAsync(Guid accountId)
        {
            return await _context.Transactions
                .Where(t => t.AccountId == accountId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Transaction>> GetByCategoryIdAsync(Guid categoryId)
        {
            return await _context.Transactions
                .Where(t => t.CategoryId == categoryId)
                .ToListAsync();
        }
    }
}
