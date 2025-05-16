using BudgetFlow.Domain.Data;
using BudgetFlow.Domain.Entities;
using BudgetFlow.Domain.Repositories;

namespace BudgetFlow.Infrastructure.Repositories
{
    public class SpendingLimitsRepository : GenericRepository<SpendingLimits>, ISpendingLimitsRepository
    {
        public SpendingLimitsRepository(IApplicationDbContext context) : base(context) { }
    }
}
