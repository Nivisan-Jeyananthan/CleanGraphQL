namespace Mediator.Core.Interfaces.Services.Queries.Base
{
    public interface IBaseQueryService<TEntity, TKey>
        where TEntity : class
        where TKey : struct
    {
        Task<IEnumerable<TEntity?>?> GetAll();
        Task<IEnumerable<TEntity?>?> GetAllAsync();
        TEntity? GetByKey(TKey id);
        Task<TEntity?> GetByKeyAsync(TKey id);
    }
}