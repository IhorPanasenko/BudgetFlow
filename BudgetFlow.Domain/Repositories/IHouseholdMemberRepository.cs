using BudgetFlow.Domain.Entities;

namespace BudgetFlow.Domain.Repositories
{
    public interface IHouseholdMemberRepository : IRepository<HouseholdMember>
    {
        Task<IEnumerable<HouseholdMember>> GetByUserIdAsync(Guid userId);
    }
}
