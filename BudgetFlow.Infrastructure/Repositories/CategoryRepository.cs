using BudgetFlow.Application.Database;
using BudgetFlow.Domain.Entities;
using BudgetFlow.Domain.Repositories;

namespace BudgetFlow.Infrastructure.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(IApplicationDbContext context) : base(context) { }

        public Task<IEnumerable<Category>> GetByHouseholdIdAsync(Guid householdId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetDefault()
        {
            throw new NotImplementedException();
        }
    }
}
