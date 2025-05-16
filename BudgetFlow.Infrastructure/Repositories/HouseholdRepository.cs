using BudgetFlow.Domain.Data;
using BudgetFlow.Domain.Entities;
using BudgetFlow.Domain.Repositories;

namespace BudgetFlow.Infrastructure.Repositories
{
    public class HouseholdRepository : GenericRepository<Household>, IHouseholdRepository
    {
        public HouseholdRepository(IApplicationDbContext context) : base(context) { }
    }
}
