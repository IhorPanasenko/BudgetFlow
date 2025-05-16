using BudgetFlow.Domain.Data;
using BudgetFlow.Domain.Entities;
using BudgetFlow.Domain.Repositories;

namespace BudgetFlow.Infrastructure.Repositories
{
    public class SavingGoalRepository : GenericRepository<SavingsGoal>, ISavingGoalRepository
    {
        public SavingGoalRepository(IApplicationDbContext context) : base(context) { }
    }
}
