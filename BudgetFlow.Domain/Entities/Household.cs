using System.ComponentModel.DataAnnotations;

namespace BudgetFlow.Domain.Entities
{
    public class Household : BaseModel
    {
        [Required]
        public string Name { get; set; }
        public Guid CreatedByUserId { get; set; }

        public ICollection<HouseholdMember> UserHouseholds { get; set; } = new List<HouseholdMember>();
        public ICollection<Account> Accounts { get; set; } = new List<Account>();
    }
}
