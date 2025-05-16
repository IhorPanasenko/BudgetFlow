using BudgetFlow.Application.Database;
using BudgetFlow.Domain.Entities;
using BudgetFlow.Domain.Repositories;

namespace BudgetFlow.Infrastructure.Repositories
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        private readonly IApplicationDbContext _context;

        public AccountRepository(IApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public Task<IEnumerable<Account>> GetByHouseholdIdAndUserIdAsync(Guid householdId, Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Account>> GetByHouseholdIdAsync(Guid householdId)
        {
            throw new NotImplementedException();
        }

        public Task<Account?> GetByIdAndUserIdAsync(Guid id, Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Account>> GetByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
