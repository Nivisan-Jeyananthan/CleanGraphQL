using Mediator.Core.Entities;
using Mediator.Core.Interfaces.Repositories.Commands;
using Mediator.Infrastructure.Data;
using Mediator.Infrastructure.Repositories.Commands.Base;
using Microsoft.EntityFrameworkCore;

namespace Mediator.Infrastructure.Repositories.Commands
{
    public class UserCommandRepository : BaseCommandRepository_TTT<User, int, ApplicationDbContext>, IUserCommandRepository
    {
        public UserCommandRepository(IDbContextFactory<ApplicationDbContext> dbContext) : base(dbContext) { }

    }
}
