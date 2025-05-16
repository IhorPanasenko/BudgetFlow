using BudgetFlow.Application.Database;
using BudgetFlow.Application.Users.Responses;
using BudgetFlow.Domain.Entities;
using BudgetFlow.Domain.Entities.Enums;
using BudgetFlow.Domain.Repositories;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace BudgetFlow.Application.Users.Commands
{
    public class ResigterUserCommandHandler : IRequestHandler<RegisterUserCommand, RegistrationResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly IApplicationDbContext _context;

        public ResigterUserCommandHandler(
            IUserRepository userRepository,
            IPasswordHasher<User> passwordHasher,
            IApplicationDbContext context)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            _context = context;
        }

        public async Task<RegistrationResponse> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            if (await _userRepository.ExistsByEmailAsync(request.Email))
            {
                return new RegistrationResponse
                {
                    Success = false,
                    ErrorMessage = "User with this email already exists."
                };
            }

            var user = new User
            {
                Id = Guid.NewGuid(),
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                PhoneNumber = request.PhoneNumber,
                BirthDate = request.BirthDate,
                DateCreated = DateTime.UtcNow,
                AccountStatus = ConfirmationStatus.PendingConfirmation,
                ConfirmationCode = Guid.NewGuid().ToString()[..6] // simple 6-char code
            };

            user.PasswordHash = _passwordHasher.HashPassword(user, request.Password);

            await _userRepository.AddAsync(user);
            await _context.SaveChangesAsync(cancellationToken);

            // TODO: Send confirmation email here

            return new RegistrationResponse
            {
                Success = true,
                User = user,
            };
        }
    }
}
