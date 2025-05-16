using BudgetFlow.Domain.Entities;

namespace BudgetFlow.Domain.Repositories
{
    internal interface ISpendingLimitsRepository : IRepository<SpendingLimits>
    {
        Task<IEnumerable<SpendingLimits>> GetByUserIdAsync(Guid userId);
        Task<IEnumerable<SpendingLimits>> GetByHouseholdIdAsync(Guid householdId);
        Task<IEnumerable<SpendingLimits>> GetByAccountIdAsync(Guid accountId);
        Task<IEnumerable<SpendingLimits>> GetByCategoryIdAsync(Guid categoryId);
    }
}
