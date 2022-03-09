using AutoMapper;
using Mediator.Application.Commands;
using Mediator.Core.Entities;
using Mediator.Core.Interfaces.Services.Commands;
using MediatR;

namespace Mediator.Application.Handlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly IUserCommandService _userCommandService;
        private readonly IMapper _mapper;
        public CreateUserCommandHandler(IUserCommandService userCommandService, IMapper mapper)
        {
            _userCommandService = userCommandService;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreateUserCommand input, CancellationToken cancellationToken)
        {
            var mappedUser = _mapper.Map<User>(input);
            if (mappedUser == null) return false;

            return await _userCommandService.AddAsync(mappedUser);
        }
    }
}
