using BudgetFlow.Application.Database;
using BudgetFlow.Domain.Entities;
using BudgetFlow.Domain.Repositories;

namespace BudgetFlow.Infrastructure.Repositories
{
    public class BankConnectionRepository : GenericRepository<BankConnection>, IBankConnectionRepository
    {
        public BankConnectionRepository(IApplicationDbContext context) : base(context) { }

        public Task<IEnumerable<BankConnection>> GetByHouseholdIdAsync(Guid householdId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BankConnection>> GetByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
