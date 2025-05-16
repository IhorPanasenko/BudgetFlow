using BudgetFlow.Domain.Entities;

namespace BudgetFlow.Domain.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<IEnumerable<Category>> GetByUserIdAsync(Guid userId);
        Task<IEnumerable<Category>> GetDefault();
        Task<IEnumerable<Category>> GetByHouseholdIdAsync(Guid householdId);
    }
}
