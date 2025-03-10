﻿using CHSMonitoring.Infrastructure.Abstractions.Telegram;
using CHSMonitoring.Infrastructure.Context;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Interfaces.TelegramBot;
using CHSMonitoring.Infrastructure.Interfaces.Workers;
using CHSMonitoring.Infrastructure.Repositories;
using CHSMonitoring.Infrastructure.Services;
using CHSMonitoring.Infrastructure.Services.TelegramBot;
using CHSMonitoring.Infrastructure.Settings;
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
        //HttpClients
        // services.AddHttpClient("yandexApi", (serviceProvider, httpClient) =>
        // {
        //     httpClient.BaseAddress = new Uri("https://geocode-maps.yandex.ru/1.x/?apikey=&geocode=Красноярск+Волжская,+35&lang=ru-RU&format=json");
        // });
        
        //Repositories and services
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
        services.AddScoped<ISubscriptionRepository, SubscriptionRepository>();
        services.AddScoped<IDistrictRepository, DistrictRepository>();
        services.AddScoped<IGeocodeService, GeocodeService>();

        //Http Parser Services
        services.AddSingleton<IHttpClientService, HttpClientService>();
        services.AddSingleton<IHtmlParserService, HtmlParserService>();
        services.AddSingleton<ITdContentParserService, TdContentParserService>();
        
        //Telegram Services
        services.AddSingleton<TelegramBot>();
        services.AddSingleton<ICommandExecutorService, CommandExecutorService>();
        services.AddSingleton<BaseCommand, StartCommand>();
        services.AddSingleton<BaseCommand, ShowServiceAddressInfoCommand>();
        services.AddSingleton<BaseCommand, ShowDistrictButtonCommand>();
        services.AddSingleton<BaseCommand, ShowDistrictSubscriptionButtonsCommand>();
        services.AddSingleton<BaseCommand, StartSubscribeCommand>();
        services.AddSingleton<BaseCommand, ShowUserTimeIntervalRefreshCommand>();
        services.AddSingleton<BaseCommand, ShowSubscriptionDetailsCommand>();
        services.AddSingleton<SendMessageCommand, SendUserMessageCommand>();
        services.AddScoped<ITelegramNotifyService, TelegramNotrifyService>();
        
        services.Configure<TelegramBotSettings>(configurationManager.GetSection("TelegramBot"));
        services.AddDbContext<MonitoringDbContext>(options =>
        {
            options.UseNpgsql(configurationManager.GetConnectionString("DefaultConnectionString"));
            options.EnableSensitiveDataLogging(false);
        });

        services.AddHostedService<ServiceMessageWorker>();
        services.AddHostedService<GInfoWorker>();
        services.AddHostedService<SubscribeNotifyWorker>();
        
        return services;
    }
}