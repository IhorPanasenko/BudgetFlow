using BudgetFlow.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace BudgetFlow.Domain.Entities
{
    public class User : BaseModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public ConfirmationStatus AccountStatus { get; set; }
        public string? ConfirmationCode { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public bool IsBankSyncEnabled { get; set; }
        public ICollection<HouseholdMember> UHouseholdMemberships { get; set; } = new List<HouseholdMember>();
        public ICollection<Account> Accounts { get; set; } = new List<Account>();
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
