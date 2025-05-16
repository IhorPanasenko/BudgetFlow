using BudgetFlow.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace BudgetFlow.Domain.Entities
{
    public class HouseholdMember : BaseModel
    {
        [Required]
        public Guid UserId { get; set; }
        public User User { get; set; }

        [Required]
        public Guid HouseholdId { get; set; }
        public Household Household { get; set; }
        public HouseholdMemberRole Role { get; set; }
    }
}
