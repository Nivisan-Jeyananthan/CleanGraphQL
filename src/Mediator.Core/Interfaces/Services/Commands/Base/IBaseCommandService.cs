namespace Mediator.Core.Interfaces.Services.Commands.Base
{
    public interface IBaseCommandService_TT<TEntity, TKey>
        where TEntity : class
        where TKey : struct
    {
        bool Add(TEntity entity);
        Task<bool> AddAsync(TEntity entity);
    }
}
