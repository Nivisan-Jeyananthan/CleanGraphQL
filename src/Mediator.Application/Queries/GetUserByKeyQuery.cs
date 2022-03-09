using Mediator.Application.Queries.Base;
using MediatR;

namespace Mediator.Application.Queries;

public record GetUserByKeyQuery(int Id) : IRequest<BaseUserQueryResponse?>;