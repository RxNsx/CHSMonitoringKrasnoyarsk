using FluentValidation;

namespace CHSMonitoring.Application.Commands.User.Register;

public class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
{
    /// <summary>
    /// Параметры длины имени пользователя
    /// </summary>
    private const int MinUserNameLength = 2;
    private const int MaxUserNameLength = 32;
    
    /// <summary>
    /// Параметры длины логина пользователя
    /// </summary>
    private const int MinLoginLength = 5;
    private const int MaxLoginLength = 32;
    
    /// <summary>
    /// Параметры длины пароля
    /// </summary>
    private const int MinPasswordLength = 5;
    private const int MaxPasswordLength = 32;
    
    public RegisterUserCommandValidator()
    {
        RuleFor(x => x.UserName)
            .Must(x => !x.Contains(" "))
                .WithMessage("User name must not contain spaces")
            .Must(x => x.Length >= MinUserNameLength && x.Length <= MaxUserNameLength)
                .WithMessage($"User name length must be between {MinUserNameLength} and {MaxUserNameLength} symbols")
            .Must(x => !x.Any(char.IsPunctuation))
                .WithMessage("User name must not contain punctuation")
            .NotNull()
                .WithMessage("User name is required")
            .NotEmpty()
                .WithMessage("User name is required");
        
        RuleFor(x => x.Email)
            .Must(x => !x.Contains(" "))
                .WithMessage("Email must not contain spaces")
            .EmailAddress()
                .WithMessage("Invalid email address")
            .NotNull()
                .WithMessage("Email is required")
            .NotEmpty()
                .WithMessage("Email is required");
        
        RuleFor(x => x.LoginName)
            .Must(x => !x.Contains(" "))
                .WithMessage("LoginName must not contain spaces")
            .Must(x => x.Length >= MinLoginLength && x.Length <= MaxLoginLength)
                .WithMessage($"Login length must be between {MinLoginLength} and {MaxLoginLength} symbols")
            .NotNull()
                .WithMessage("Login is required")
            .NotEmpty()
                .WithMessage("Login is required");
        
        RuleFor(x => x.Password)
            .Must(x => !x.Contains(" "))
                .WithMessage("Password must not contain spaces")
            .Must(x => x.Length >= MinPasswordLength && x.Length <= MaxPasswordLength)
                .WithMessage($"Password length must be between {MinPasswordLength} and {MaxPasswordLength} symbols")
            .Must(x => x.Any(char.IsDigit) && x.Any(char.IsLetter))
                .WithMessage($"Password must contain at least one digit and one letter")
            .NotNull()
                .WithMessage("Password is required")
            .NotEmpty()
                .WithMessage("Password is required");
        
    }
}