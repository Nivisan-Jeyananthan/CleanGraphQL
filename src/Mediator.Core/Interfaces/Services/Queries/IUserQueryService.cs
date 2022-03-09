using Mediator.Core.Entities;
using Mediator.Core.Interfaces.Services.Queries.Base;

namespace Mediator.Core.Interfaces.Services.Queries
{
    public interface IUserQueryService : IBaseQueryService<User, int>
    {
    }
}