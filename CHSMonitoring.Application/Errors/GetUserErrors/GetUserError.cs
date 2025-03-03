using Shared;

namespace CHSMonitoring.Application.Errors.GetUserErrors;

/// <summary>
/// Ошибки получения пользователя
/// </summary>
public static class GetUserError
{
    public static Error NotFoundWebProfile => new("Web profile not found", ErrorTypeEnum.NotFound); 
}