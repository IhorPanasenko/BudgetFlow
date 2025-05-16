using BudgetFlow.Domain.Entities;

namespace BudgetFlow.Domain.Repositories
{
    public interface ISavingGoalRepository : IRepository<SavingsGoal>
    {
        Task<IEnumerable<SavingsGoal>> GetByUserIdAsync(Guid userId);
        Task<IEnumerable<SavingsGoal>> GetByHouseholdIdAsync(Guid householdId);
        Task<IEnumerable<SavingsGoal>> GetByAccountIdAsync(Guid accountId);
        Task<IEnumerable<SavingsGoal>> GetByCategoryIdAsync(Guid categoryId);
    }
}
