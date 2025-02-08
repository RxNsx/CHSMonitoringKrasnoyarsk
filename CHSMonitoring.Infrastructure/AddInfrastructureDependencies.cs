using CHSMonitoring.Infrastructure.Context;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Repositories;
using CHSMonitoring.Infrastructure.Services;
using CHSMonitoring.Infrastructure.Workers;
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
        services.AddScoped<IStreetRepository, StreetRepository>();
        services.AddScoped<IStreetNameService, StreetNameService>();
        services.AddScoped<IOrganizationParserService, OrganizationParserService>();
        services.AddScoped<IAddressParserService, AddressParserService>();
        services.AddScoped<IDateParserService, DateParserService>();
        
        services.AddDbContext<MonitoringDbContext>(options =>
        {
            options.UseNpgsql(configurationManager.GetConnectionString("DefaultConnectionString"));
        });

        services.AddHostedService<ServiceMessageWorker>();
        // services.AddHostedService<GInfoWorker>();
        
        return services;
    }
}