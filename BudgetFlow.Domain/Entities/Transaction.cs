using BudgetFlow.Domain.Entities.Enums;

namespace BudgetFlow.Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public TransactionType Type { get; set; }
        public bool IsAuto { get; set; }
        public string? ExternalTransactionId { get; set; }
        public string[]? Attachments { get; set; }

        public Account Account { get; set; }
    }

}
