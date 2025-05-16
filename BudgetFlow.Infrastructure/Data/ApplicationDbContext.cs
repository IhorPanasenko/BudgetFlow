using BudgetFlow.Application.Database;
using BudgetFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BudgetFlow.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext, IApplciationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SavingsGoal> Budgets { get; set; }
        public DbSet<SpendingLimits> SpendingLimits { get; set; }
        public DbSet<Household> Households { get; set; }
        public DbSet<HouseholdMember> HouseholdMembers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
            => base.SaveChangesAsync(cancellationToken);
    }
}
