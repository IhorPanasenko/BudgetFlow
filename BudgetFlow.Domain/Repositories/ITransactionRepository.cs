using BudgetFlow.Domain.Entities;

namespace BudgetFlow.Domain.Repositories
{
    public interface ITransactionRepository : IRepository<Transaction>
    {
        Task<IEnumerable<Transaction>> GetByUserIdAsync(Guid userId);
        Task<IEnumerable<Transaction>> GetByHouseholdIdAsync(Guid householdId);
        Task<IEnumerable<Transaction>> GetByAccountIdAsync(Guid accountId);
        Task<IEnumerable<Transaction>> GetByCategoryIdAsync(Guid categoryId);
    }
}
