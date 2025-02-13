using FluentValidation;

namespace CHSMonitoring.Application.Commands.Login;

public class LoginUserCommandValidator : AbstractValidator<LoginUserCommand>
{
    public LoginUserCommandValidator()
    {
        RuleFor(x => x.LoginName)
            .NotNull().WithMessage("Login name is required")
            .NotEmpty().WithMessage("Login name is required");
        
        RuleFor(x => x.Password)
            .NotNull().WithMessage("Password is required")
            .NotEmpty().WithMessage("Password is required");
    }
}