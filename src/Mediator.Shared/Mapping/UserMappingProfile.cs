using AutoMapper;
using Mediator.Application.Commands;
using Mediator.Application.Queries.Base;
using Mediator.Core.Entities;

namespace Mediator.Shared.Mapping
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<CreateUserCommand, User>();

            CreateMap<User,BaseUserQueryResponse>();
        }
    }
}
