using MediatR;

namespace Mediator.Application.Commands;

public record CreateUserCommand(string Username, string FirstName, string LastName, string Email, string Password) : IRequest<bool>;