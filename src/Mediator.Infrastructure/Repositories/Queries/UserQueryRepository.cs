using Mediator.Core.Entities;
using Mediator.Core.Interfaces.Repositories.Queries;
using Mediator.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Mediator.Infrastructure.Repositories.Queries
{
    public class UserQueryRepository : BaseQueryRepository_TTT<User, int, ApplicationDbContext>, IUserQueryRepository
    {
        public UserQueryRepository(IDbContextFactory<ApplicationDbContext> appContextFactory) : base(appContextFactory)
        {

        }
    }
}
