using BudgetFlow.Domain.Entities.Enums;

namespace BudgetFlow.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public string? ConfirmationCode { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<UserHousehold> UserHouseholds { get; set; }
    }
}
