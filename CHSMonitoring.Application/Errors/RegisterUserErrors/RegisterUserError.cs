using Shared;

namespace CHSMonitoring.Application.Errors.RegisterUserErrors;

/// <summary>
/// Ошибки регистрации пользователя
/// </summary>
public static class RegisterUserError
{
    /// <summary>
    /// Пользователь существует
    /// </summary>
    /// <returns></returns>
    public static Error UserAlreadyExists() => new("User is already exists", ErrorTypeEnum.Validation);
}