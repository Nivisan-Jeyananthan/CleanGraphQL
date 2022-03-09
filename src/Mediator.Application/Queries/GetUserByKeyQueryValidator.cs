using FluentValidation;

namespace Mediator.Application.Queries
{
    public class GetUserByKeyQueryValidator : AbstractValidator<GetUserByKeyQuery>
    {
        public GetUserByKeyQueryValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
