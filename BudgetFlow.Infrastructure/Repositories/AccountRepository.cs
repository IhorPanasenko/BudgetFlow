using BudgetFlow.Domain.Data;
using BudgetFlow.Domain.Entities;
using BudgetFlow.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BudgetFlow.Infrastructure.Repositories
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        private readonly IApplicationDbContext _context;

        public AccountRepository(IApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
