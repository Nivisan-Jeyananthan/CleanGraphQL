namespace Mediator.Core.Interfaces.Repositories.Queries.Base
{
    public interface IBaseQueryRepository_TT<TEntity, TKey>
        where TEntity : class
        where TKey : struct
    {
        TEntity? GetByKey(TKey key);
        Task<TEntity?> GetByKeyAsync(TKey key);
    }
}