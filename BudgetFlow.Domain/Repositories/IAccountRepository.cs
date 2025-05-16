using BudgetFlow.Domain.Entities;

namespace BudgetFlow.Domain.Repositories
{
    public interface IAccountRepository : IRepository<Account>
    {
        Task<IEnumerable<Account>> GetByUserIdAsync(Guid userId);
        Task<Account?> GetByIdAndUserIdAsync(Guid id, Guid userId);
        Task<IEnumerable<Account>> GetByHouseholdIdAsync(Guid householdId);
        Task<IEnumerable<Account>> GetByHouseholdIdAndUserIdAsync(Guid householdId, Guid userId);
    }
}
