using BudgetFlow.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace BudgetFlow.Domain.Entities
{
    public class Transaction : BaseModel
    {
        [Required]
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public TransactionType Type { get; set; }
        public bool IsAutoImported { get; set; }
        public string? ExternalTransactionId { get; set; }
        public string? Description { get; set; }
        public List<string> ImageUrls { get; set; } = new List<string>();

        [Required]
        public Guid UserId { get; set; }
        public User User { get; set; }

        [Required]
        public Guid AccountId { get; set; }
        public Account Account { get; set; }

        [Required]
        public Guid? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
