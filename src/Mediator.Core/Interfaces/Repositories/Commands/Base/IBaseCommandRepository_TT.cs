namespace Mediator.Core.Interfaces.Repositories.Commands.Base
{
    public interface IBaseCommandRepository_TT<TEntity, TKey>
    where TEntity : class
    where TKey : struct
    {
        bool Add(TEntity entity);
        Task<bool> AddAsync(TEntity? entity);
    }
}
