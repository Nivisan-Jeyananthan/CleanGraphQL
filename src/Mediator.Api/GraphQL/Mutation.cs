using HotChocolate.Resolvers;
using Mediator.Application.Commands;
using MediatR;

namespace Mediator.Api.GraphQL
{
    public class Mutation
    {
        public async Task<bool> Add(CreateUserCommand command, IResolverContext context, [Service] IMediator mediator)
        {
            try
            {
                return await mediator.Send(command);

            }
            catch (Exception ex)
            {
                context.ReportError(ex.Message);
                return false;
            }
        }

    }
}
