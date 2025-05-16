using System.ComponentModel.DataAnnotations;

namespace BudgetFlow.Domain.Entities
{
    public class Account : BaseModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Currency {  get; set; }
        [Required]
        public decimal Balance { get; set; }
        public bool IsShared { get; set; }
        public bool IsBankSynced { get; set; }

        [Required]
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid HouseholdId { get; set; }
        public Household Household { get; set; }
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public ICollection<BankConnection> BankConnections { get; set; } = new List<BankConnection>();
    }
}
