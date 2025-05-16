using BudgetFlow.Application.Database;
using BudgetFlow.Domain.Entities;
using BudgetFlow.Domain.Repositories;

namespace BudgetFlow.Infrastructure.Repositories
{
    public class HouseholdRepository : GenericRepository<Household>, IHouseholdRepository
    {
        public HouseholdRepository(IApplicationDbContext context) : base(context) { }

        public Task<IEnumerable<Household>> GetByAccountIdAsync(Guid accountId)
        {
            throw new NotImplementedException();
        }

        public Task<Household?> GetByIdAndUserIdAsync(Guid id, Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Household>> GetByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
