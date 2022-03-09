using Mediator.Application.Queries;
using Mediator.Application.Queries.Base;
using MediatR;

namespace Mediator.Api.GraphQL
{
    public class Query
    {
        public Task<BaseUserQueryResponse?> GetUserByKey([Service] IMediator mediator, GetUserByKeyQuery input)
        {
            return mediator.Send(input);
        }
    }
}
