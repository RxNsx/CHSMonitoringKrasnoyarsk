using VplayRequestTransmitter.Shared;

namespace CHSMonitoring.Application.Errors.LoginUserErrors;

/// <summary>
/// Ошибки авторизации пользователя
/// </summary>
public static class LoginUserError
{
    /// <summary>
    /// Пользователь не найден
    /// </summary>
    /// <returns></returns>
    public static Error NotFound() => new("User not found", ErrorTypeEnum.NotFound);
    
    /// <summary>
    /// Неверный пароль пользователя
    /// </summary>
    /// <returns></returns>
    public static Error IncorrectPassword() => new ("Password is incorrect", ErrorTypeEnum.Validation);
}