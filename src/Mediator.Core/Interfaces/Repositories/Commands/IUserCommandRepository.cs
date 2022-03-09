using Mediator.Core.Entities;
using Mediator.Core.Interfaces.Repositories.Commands.Base;

namespace Mediator.Core.Interfaces.Repositories.Commands
{
    public interface IUserCommandRepository : IBaseCommandRepository_TT<User, int>
    {
    }
}
