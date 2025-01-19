using Microsoft.Extensions.DependencyInjection;

namespace CHSMonitoring.Application;

/// <summary>
/// Зависимости слоя приложения
/// </summary>
public static class AddApplicationDependencies
{
    /// <summary>
    /// Добавление сервисов слоя приложения
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        return services;
    }
}