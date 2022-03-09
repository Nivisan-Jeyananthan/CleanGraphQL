using Mediator.Application.Services.Commands.Base;
using Mediator.Core.Entities;
using Mediator.Core.Interfaces.Repositories.Commands;
using Mediator.Core.Interfaces.Services.Commands;

namespace Mediator.Application.Services.Commands
{
    public class UserCommandService : BaseCommandService_TT<User, int, IUserCommandRepository>, IUserCommandService
    {
        public UserCommandService(IUserCommandRepository repository) : base(repository)
        {
        }
    }
}
