using FluentValidation;

namespace CHSMonitoring.Application.Queries.User.Get;

public class GetUserQueryValidator : AbstractValidator<GetUserQuery>
{
    public GetUserQueryValidator()
    {
        RuleFor(x => x.LoginName)
            .NotEmpty().WithMessage($"User id is required")
            .NotNull().WithMessage($"User id is required");
    }
}