using BudgetFlow.Domain.Entities;

namespace BudgetFlow.Domain.Repositories
{
    public interface IHouseholdRepository : IRepository<Household>
    {
        Task<Household?> GetByIdAndUserIdAsync(Guid id, Guid userId);
        Task<IEnumerable<Household>> GetByUserIdAsync(Guid userId);
        Task<IEnumerable<Household>> GetByAccountIdAsync(Guid accountId);
    }
}
