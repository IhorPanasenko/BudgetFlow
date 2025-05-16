using System.ComponentModel.DataAnnotations;

namespace BudgetFlow.Domain.Entities
{
    public class BankConnection : BaseModel
    {
        public string BankName { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime ConnectedAt { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime ExpiresAt { get; set; }

        [Required]
        public Guid AccountId { get; set; }
        public Account Acconut { get; set; }
    }
}
