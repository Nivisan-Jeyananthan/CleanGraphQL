using Mediator.Core.Interfaces.Repositories.Queries.Base;
using Microsoft.EntityFrameworkCore;

namespace Mediator.Infrastructure.Repositories.Queries;


public abstract class BaseQueryRepository_TTT<TEntity, TKey, TDbContext> : IBaseQueryRepository_TT<TEntity, TKey>
   where TEntity : class
   where TKey : struct
   where TDbContext : DbContext
{
    protected readonly TDbContext _dbContext;
    public BaseQueryRepository_TTT(IDbContextFactory<TDbContext> dbContext) => _dbContext = dbContext.CreateDbContext();

    public TEntity? GetByKey(TKey key)
    {
        return _dbContext.Set<TEntity>().Find(key);
    }
    public async Task<TEntity?> GetByKeyAsync(TKey key)
    {
        return await _dbContext.Set<TEntity>().FindAsync(key);
    }
}
