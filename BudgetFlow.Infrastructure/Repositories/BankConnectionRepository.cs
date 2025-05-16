using BudgetFlow.Domain.Data;
using BudgetFlow.Domain.Entities;
using BudgetFlow.Domain.Repositories;

namespace BudgetFlow.Infrastructure.Repositories
{
    public class BankConnectionRepository : GenericRepository<BankConnection>, IBankConnectionRepository
    {
        public BankConnectionRepository(IApplicationDbContext context) : base(context) { }

    }
}
