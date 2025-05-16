namespace BudgetFlow.Domain.Entities
{
    public class SavingsGoal : BaseModel
    {
        public decimal TargetAmount { get; set; }
        public string? Name { get; set; }
        public DateTime TargetDate { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid? AccountId { get; set; }        //if null applies to sum of all user's accounts
        public Account? Account { get; set; }
    }
}
