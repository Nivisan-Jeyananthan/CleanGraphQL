using Mediator.Core.Interfaces.Repositories.Queries.Base;
using Mediator.Core.Interfaces.Services.Queries.Base;

namespace Mediator.Application.Services.Queries.Base
{
    public class BaseQueryService_TTT<TEntity, TKey, TQueryRepository> : IBaseQueryService<TEntity, TKey>
        where TEntity : class
        where TKey : struct
        where TQueryRepository : IBaseQueryRepository_TT<TEntity, TKey>
    {
        protected readonly TQueryRepository _repository;
        public BaseQueryService_TTT(TQueryRepository repository)
        {
            _repository = repository ?? throw new NotImplementedException(nameof(repository));
        }

        public Task<IEnumerable<TEntity?>?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity?>?> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public TEntity? GetByKey(TKey id)
        {
            return _repository.GetByKey(id);

        }
        public async Task<TEntity?> GetByKeyAsync(TKey id)
        {
            return await _repository.GetByKeyAsync(id);
        }
    }
}
