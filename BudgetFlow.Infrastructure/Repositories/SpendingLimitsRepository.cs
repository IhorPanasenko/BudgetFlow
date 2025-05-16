using BudgetFlow.Application.Database;
using BudgetFlow.Domain.Entities;
using BudgetFlow.Domain.Repositories;

namespace BudgetFlow.Infrastructure.Repositories
{
    public class SpendingLimitsRepository : GenericRepository<SpendingLimits>, ISpendingLimitsRepository
    {
        public SpendingLimitsRepository(IApplicationDbContext context) : base(context) { }

        public Task<IEnumerable<SpendingLimits>> GetByAccountIdAsync(Guid accountId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SpendingLimits>> GetByCategoryIdAsync(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SpendingLimits>> GetByHouseholdIdAsync(Guid householdId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SpendingLimits>> GetByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
