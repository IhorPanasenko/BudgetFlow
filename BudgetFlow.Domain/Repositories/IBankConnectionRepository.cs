using BudgetFlow.Domain.Entities;

namespace BudgetFlow.Domain.Repositories
{
    public interface IBankConnectionRepository : IRepository<BankConnection>
    {
        Task<IEnumerable<BankConnection>> GetByUserIdAsync(Guid userId);
        Task<IEnumerable<BankConnection>> GetByHouseholdIdAsync(Guid householdId);
    }
}
