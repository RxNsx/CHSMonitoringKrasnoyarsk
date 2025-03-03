using Shared;

namespace CHSMonitoring.Application.Errors.ServiceAddressErrors;

/// <summary>
/// Ошибки сущности обслуживающего адреса
/// </summary>
public static class ServiceAddressError
{
    public static Error NotFound() => new("Service address not found", ErrorTypeEnum.NotFound);
}