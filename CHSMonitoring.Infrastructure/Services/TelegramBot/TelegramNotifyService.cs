using System.Text;
using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Domain.Enums;
using CHSMonitoring.Infrastructure.Common;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Interfaces.TelegramBot;
using Microsoft.Extensions.DependencyInjection;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace CHSMonitoring.Infrastructure.Services.TelegramBot;

/// <summary>
/// Сервис уведомлений
/// </summary>
public class TelegramNotrifyService : ITelegramNotifyService
{
    private readonly TelegramBotClient _telegramBotClient;
    private readonly IServiceAddressRepository _serviceAddressRepository;
    private readonly IProfileRepository _profileRepository;
    private readonly IUserRepository _userRepository;

    /// <summary>
    /// Конструктор
    /// </summary>
    public TelegramNotrifyService(Telegram.TelegramBot telegramBot, IServiceScopeFactory serviceScopeFactory)
    {
        _telegramBotClient = telegramBot.GetTelegramBotClient().Result;
        var scope = serviceScopeFactory.CreateScope();
        _serviceAddressRepository  = scope.ServiceProvider.GetRequiredService<IServiceAddressRepository>();
        _profileRepository = scope.ServiceProvider.GetRequiredService<IProfileRepository>();
        _userRepository = scope.ServiceProvider.GetRequiredService<IUserRepository>();
    }

    public async Task SendNotifyMessageAsync(string message, List<User> notifyUsers, CancellationToken cancellationToken)
    {
        foreach (var user in notifyUsers)
        {
            var serviceAddresses = await _serviceAddressRepository.GetLatestServiceAddressByDistrictAsync(user.Subscription.DistrictId, cancellationToken)
                .ConfigureAwait(false);
            var profile = await _profileRepository.GetTelegramProfileAsync(user.Id, cancellationToken).ConfigureAwait(false);
            var payload = BuildPayloadString(serviceAddresses);
            await _telegramBotClient.SendMessage(profile!.ProviderId, payload, ParseMode.Markdown);
            await _userRepository.UpdateUserNotifyUpdateDateAsync(user.Id, cancellationToken).ConfigureAwait(false);
            await Task.Delay(TimeSpan.FromSeconds(1));
        }
    }
    
    /// <summary>
    /// Подготовить текст для отправки
    /// </summary>
    /// <param name="targetList"></param>
    /// <returns></returns>
    private string BuildPayloadString(List<ServiceAddress> targetList)
    {
        if (!targetList.Any())
        {
            return string.Empty;
        }
        
        var sb = new StringBuilder();

        var groupedServiceAddresses = targetList
            .Where(x => x.From != null && x.To != null)
            .GroupBy(x => new { x.DistrictId, x.ServiceTypeId, x.StreetId, x.Description, x.From, x.To })
            .Select(x =>
            {
                var houseNumbersList = x.Select(t => t.HouseNumber).ToList();
                houseNumbersList.Sort();
                
                return new
                {
                    DistrictId = x.Key.DistrictId,
                    ServiceTypeId = x.Key.ServiceTypeId,
                    StreetId = x.Key.StreetId,
                    Description = x.Key.Description,
                    From = x.Key.From,
                    To = x.Key.To,
                    HouseNumbersList = string.Join(", ", houseNumbersList)
                };
            })
            .GroupBy(x => x.DistrictId)
            .ToDictionary(x => x.Key, x => x.ToList())
            .ToList();

        foreach (var group in groupedServiceAddresses)
        {
            var districtName = CommonData.DistrictsData.FirstOrDefault(x => x.Id == group.Key);
            sb.AppendLine().AppendLine($"🚨 {districtName.DistrictName} 🚨").AppendLine();
            
            var groupedByServiceType = group.Value
                .GroupBy(x => x.ServiceTypeId)
                .ToDictionary(x => x.Key, x => x.ToList());
            foreach (var groupServiceTypeItem in groupedByServiceType)
            {
                var serviceTypeName = CommonData.ServiceTypesData.FirstOrDefault(x => x.Id == groupServiceTypeItem.Key).ServiceTypeName;
                sb.AppendLine(serviceTypeName).AppendLine();
                
                foreach (var serviceAddressItem in groupServiceTypeItem.Value)
                {
                    var streetName = CommonData.StreetsData.FirstOrDefault(x => x.Id == serviceAddressItem.StreetId).StreetName;
                    var serviceTypeEnum = Enum.GetValues(typeof(ServiceTypeEnum))
                        .Cast<ServiceTypeEnum>()
                        .FirstOrDefault(x => x.GetGuidValue() == serviceAddressItem.ServiceTypeId);
                            
                    var serviceType = string.Empty;
                    switch (serviceTypeEnum)
                    {
                        case ServiceTypeEnum.Electricity:
                            serviceType = "⚡️";
                            break;
                        case ServiceTypeEnum.ColdWater:
                            serviceType = "💧";
                            break;
                        case ServiceTypeEnum.HotWater:
                            serviceType = "💨";
                            break;
                    }
                            
                    sb.AppendLine($"{serviceType} {streetName}, {serviceAddressItem.HouseNumbersList}");
                    sb.AppendLine($"⏰ {serviceAddressItem.From} - ⏰ {serviceAddressItem.To}");
                }
            }
        }

        return sb.ToString();
    }
}