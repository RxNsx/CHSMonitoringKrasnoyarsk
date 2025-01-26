using CHSMonitoring.Infrastructure.Context;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CHSMonitoring.Infrastructure;

/// <summary>
/// Добавление сервисов слоя инфраструктуры
/// </summary>
public static class AddInfrastructureDependencies
{
    /// <summary>
    /// Добавление сервисов слоя инфраструктуры
    /// </summary>
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfigurationManager configurationManager)
    {
        services.AddScoped<IServiceAddressRepository, ServiceAddressRepository>();
        
        services.AddDbContext<MonitoringDbContext>(options =>
        {
            options.UseNpgsql(configurationManager.GetConnectionString("DefaultConnectionString"));
        });
        
        return services;
    }
}