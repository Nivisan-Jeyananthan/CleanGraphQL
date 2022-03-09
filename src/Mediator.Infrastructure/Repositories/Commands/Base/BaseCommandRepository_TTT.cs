using Mediator.Core.Interfaces.Repositories.Commands.Base;
using Microsoft.EntityFrameworkCore;

namespace Mediator.Infrastructure.Repositories.Commands.Base
{
    public abstract class BaseCommandRepository_TTT<TEntity, TKey, TDbContext> : IBaseCommandRepository_TT<TEntity, TKey>
        where TEntity : class
        where TKey : struct
        where TDbContext : DbContext
    {
        protected readonly TDbContext _dbContext;

        public BaseCommandRepository_TTT(IDbContextFactory<TDbContext> dbContext) => _dbContext = dbContext.CreateDbContext();

        ~BaseCommandRepository_TTT()
        {
            _dbContext.Dispose();
            GC.Collect();
        }

        /// <summary>
        /// Adds the entity to the database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>The sucessstatus of the operation as a bool</returns>
        public bool Add(TEntity? entity)
        {
            if (entity == null) return false;

            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
            return true;
        }

        /// <summary>
        /// Adds the entity to the database asynchronously
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>The sucessstatus of the operation as a bool</returns>
        public async Task<bool> AddAsync(TEntity? entity)
        {
            if (entity == null) return false;

            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }


    }
}
