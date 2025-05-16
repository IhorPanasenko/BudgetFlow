using System.ComponentModel.DataAnnotations;

namespace BudgetFlow.Domain.Entities
{
    public class SpendingLimits : BaseModel
    {
        public decimal LimitAmount { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        [Required]
        public Guid UserId { get; set; }
        public User User { get; set; }

        [Required]
        public Guid? AccountId { get; set; }      //if null applies to sum of all user's accounts
        public Account? Account { get; set; }
    }
}
