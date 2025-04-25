using System.Transactions;

namespace BudgetFlow.Domain.Entities
{
    public class Account
    {
        public Guid Id { get; set; }
        public Guid HouseholdId { get; set; }
        public string Name { get; set; }

        public Household Household { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
