using AutoMapper;
using Mediator.Application.Queries;
using Mediator.Application.Queries.Base;
using Mediator.Core.Interfaces.Services.Queries;
using MediatR;

namespace Mediator.Application.Handlers
{
    public class GetUserByKeyQueryHandler : IRequestHandler<GetUserByKeyQuery, BaseUserQueryResponse?>
    {
        private readonly IUserQueryService _userQueryService;
        private readonly IMapper _mapper;
        public GetUserByKeyQueryHandler(IUserQueryService userQueryService, IMapper mapper) => (_userQueryService, _mapper) = (userQueryService, mapper);

        public async Task<BaseUserQueryResponse?> Handle(GetUserByKeyQuery input, CancellationToken cancellationToken)
        {

            var user = await _userQueryService.GetByKeyAsync(input.Id);
            if (user == null) return null;

            var mappedUser = _mapper.Map<BaseUserQueryResponse?>(user);
            return mappedUser;
        }
    }
}
