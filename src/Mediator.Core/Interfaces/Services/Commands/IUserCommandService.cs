using Mediator.Core.Entities;
using Mediator.Core.Interfaces.Services.Commands.Base;

namespace Mediator.Core.Interfaces.Services.Commands
{
    public interface IUserCommandService : IBaseCommandService_TT<User, int>
    {
    }
}
