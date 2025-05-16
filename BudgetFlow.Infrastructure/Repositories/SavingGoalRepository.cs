using BudgetFlow.Application.Database;
using BudgetFlow.Domain.Entities;
using BudgetFlow.Domain.Repositories;

namespace BudgetFlow.Infrastructure.Repositories
{
    public class SavingGoalRepository : GenericRepository<SavingsGoal>, ISavingGoalRepository
    {
        public SavingGoalRepository(IApplicationDbContext context) : base(context) { }

        public Task<IEnumerable<SavingsGoal>> GetByAccountIdAsync(Guid accountId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SavingsGoal>> GetByCategoryIdAsync(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SavingsGoal>> GetByHouseholdIdAsync(Guid householdId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SavingsGoal>> GetByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
