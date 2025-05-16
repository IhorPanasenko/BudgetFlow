using BudgetFlow.Domain.Entities;

namespace BudgetFlow.Application.Users.Responses
{
    public class RegistrationResponse
    {
        public bool Success { get; set; }
        public string? ErrorMessage { get; set; }
        public User? User { get; set; }
    }
}
