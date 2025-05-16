using BudgetFlow.Domain.Data;
using BudgetFlow.Domain.Entities;
using BudgetFlow.Domain.Repositories;

namespace BudgetFlow.Infrastructure.Repositories
{
    public class HouseholdMemberRepository : GenericRepository<HouseholdMember>, IHouseholdMemberRepository
    {
        public HouseholdMemberRepository(IApplicationDbContext context) : base(context) { }
    }
}
