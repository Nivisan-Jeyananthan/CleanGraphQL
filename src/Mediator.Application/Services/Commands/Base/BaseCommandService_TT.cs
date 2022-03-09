using Mediator.Core.Interfaces.Repositories.Commands.Base;
using Mediator.Core.Interfaces.Services.Commands.Base;

namespace Mediator.Application.Services.Commands.Base
{
    public class BaseCommandService_TT<TEntity, TKey, TCommandRepository> : IBaseCommandService_TT<TEntity, TKey>
            where TEntity : class
            where TKey : struct
            where TCommandRepository : IBaseCommandRepository_TT<TEntity, TKey>
    {
        protected readonly TCommandRepository _repository;
        public BaseCommandService_TT(TCommandRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public bool Add(TEntity entity)
        {
            return _repository.Add(entity);
        }
        public async Task<bool> AddAsync(TEntity entity)
        {
            return await _repository.AddAsync(entity);
        }

    }
}
