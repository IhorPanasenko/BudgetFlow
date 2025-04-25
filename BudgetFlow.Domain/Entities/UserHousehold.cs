using BudgetFlow.Domain.Entities.Enums;

namespace BudgetFlow.Domain.Entities
{
    public class UserHousehold
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid HouseholdId { get; set; }
        public Household Household { get; set; }

        public HouseholdMemberRole Role { get; set; }
    }
}
