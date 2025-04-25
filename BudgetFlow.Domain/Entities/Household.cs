namespace BudgetFlow.Domain.Entities
{
    public class Household
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<UserHousehold> UserHouseholds { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
