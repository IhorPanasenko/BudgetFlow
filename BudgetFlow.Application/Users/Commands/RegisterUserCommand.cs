using BudgetFlow.Application.Users.Responses;
using MediatR;

namespace BudgetFlow.Application.Users.Commands
{
    public class RegisterUserCommand : IRequest<RegistrationResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
