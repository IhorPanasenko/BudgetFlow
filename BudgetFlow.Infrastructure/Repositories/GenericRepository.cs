using BudgetFlow.Application.Database;
using BudgetFlow.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BudgetFlow.Infrastructure.Repositories
{
    public abstract class GenericRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        protected readonly IApplicationDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(IApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<TEntity?> GetByIdAsync(Guid id)
               => await _dbSet.FindAsync(id);

        public async Task<IEnumerable<TEntity>> GetAllAsync()
            => await _dbSet.ToListAsync();

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
            => await _dbSet.Where(predicate).ToListAsync();

        public async Task AddAsync(TEntity entity)
            => await _dbSet.AddAsync(entity);

        public void Update(TEntity entity)
            => _dbSet.Update(entity);

        public void Remove(TEntity entity)
            => _dbSet.Remove(entity);
    }
}
