using BudgetFlow.Domain.Entities.Enums;

namespace BudgetFlow.Domain.Entities
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public CategoryType Type { get; set; }
        public string ColorHex { get; set; }
        public string Icon { get; set; }
        public string IsDefault { get; set; }
        public Guid? UserID { get; set; }
        public User User { get; set; }
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
