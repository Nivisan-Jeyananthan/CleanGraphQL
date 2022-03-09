using Mediator.Application.Services.Queries.Base;
using Mediator.Core.Entities;
using Mediator.Core.Interfaces.Repositories.Queries;
using Mediator.Core.Interfaces.Services.Queries;

namespace Mediator.Application.Services.Queries
{
    public class UserQueryService : BaseQueryService_TTT<User, int, IUserQueryRepository>, IUserQueryService
    {
        public UserQueryService(IUserQueryRepository repository) : base(repository) { }
    }
}
