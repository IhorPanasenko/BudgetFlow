using Microsoft.Extensions.DependencyInjection;
using BudgetFlow.Domain.Repositories;
using BudgetFlow.Infrastructure.Repositories;
using BudgetFlow.Application.Database;
using BudgetFlow.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;

namespace BudgetFlow.Infrastructure.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("BudgetFlowDb")));

            services.AddScoped<IApplicationDbContext>(provider =>
                provider.GetRequiredService<ApplicationDbContext>());

            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
           
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IBankConnectionRepository, BankConnectionRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IHouseholdRepository, HouseholdRepository>();
            services.AddScoped<IHouseholdMemberRepository, HouseholdMemberRepository>();
            services.AddScoped<ISavingGoalRepository, SavingGoalRepository>();
            services.AddScoped<ISpendingLimitsRepository, SpendingLimitsRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<IUserRepository, UserRepository>();


            return services;
        }
    }
}
