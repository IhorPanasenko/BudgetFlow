﻿using BudgetFlow.Domain.Entities;

namespace BudgetFlow.Domain.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User?> GetByEmailAsync(string email);
    }
}
