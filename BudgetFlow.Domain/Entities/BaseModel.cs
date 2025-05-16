using System.ComponentModel.DataAnnotations;

namespace BudgetFlow.Domain.Entities
{
    public class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }
}
