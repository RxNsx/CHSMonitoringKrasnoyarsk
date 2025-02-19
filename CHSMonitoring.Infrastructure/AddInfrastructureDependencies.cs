using CHSMonitoring.Infrastructure.Abstractions.Telegram;
using CHSMonitoring.Infrastructure.Context;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Interfaces.TelegramBot;
using CHSMonitoring.Infrastructure.Interfaces.Workers;
using CHSMonitoring.Infrastructure.Repositories;
using CHSMonitoring.Infrastructure.Services;
using CHSMonitoring.Infrastructure.Services.TelegramBot;
using CHSMonitoring.Infrastructure.Telegram;
using CHSMonitoring.Infrastructure.Telegram.Commands;
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
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IHashPasswordService, HashPasswordService>();
        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<IProfileRepository, ProfileRepository>();

        services.AddSingleton<IHttpClientService, HttpClientService>();
        services.AddSingleton<IHtmlParserService, HtmlParserService>();
        services.AddSingleton<ITdContentParserService, TdContentParserService>();
        
        //Telegram Services
        services.AddSingleton<TelegramBot>();
        services.AddSingleton<ICommandExecutorService, CommandExecutorService>();
        services.AddSingleton<BaseCommand, StartCommand>();
        services.AddSingleton<BaseCommand, SetUserNameCommand>();
        services.AddSingleton<BaseCommand, SetEmailAddressCommand>();
        services.AddSingleton<BaseCommand, ResentEmailAddressCommand>();
        services.AddSingleton<BaseCommand, SuccessAuthorizationCommand>();
        services.AddSingleton<BaseCommand, UserEmailAlreadyExistsCommand>();
        services.AddSingleton<BaseCommand, ShowServiceAddressInfoCommand>();
        services.AddSingleton<BaseCommand, ShowDistrictButtonCommand>();
        services.AddSingleton<ErrorBaseCommand, SendErrorInfoCommand>();
        
        services.AddDbContext<MonitoringDbContext>(options =>
        {
            options.UseNpgsql(configurationManager.GetConnectionString("DefaultConnectionString"));
        });

        services.AddHostedService<ServiceMessageWorker>();
        // services.AddHostedService<GInfoWorker>();
        
        return services;
    }
}