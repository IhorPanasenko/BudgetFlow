using BudgetFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BudgetFlow.Application.Database
{
    public interface IApplciationDbContext
    {
        DbSet<User> Users { get; }
        DbSet<Account> Accounts { get; }
        DbSet<Transaction> Transactions { get; }
        DbSet<Category> Categories { get; }
        DbSet<SavingsGoal> Budgets { get; }
        DbSet<SpendingLimits> SpendingLimits { get; }
        DbSet<Household> Households { get; }
        DbSet<HouseholdMember> HouseholdMembers { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
