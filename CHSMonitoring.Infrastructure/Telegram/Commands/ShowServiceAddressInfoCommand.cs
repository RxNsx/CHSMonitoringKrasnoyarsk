using System.Text;
using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Domain.Enums;
using CHSMonitoring.Infrastructure.Abstractions.Telegram;
using CHSMonitoring.Infrastructure.Common;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Models.Enums;
using CHSMonitoring.Infrastructure.Settings;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CHSMonitoring.Infrastructure.Telegram.Commands;

public sealed class ShowServiceAddressInfoCommand : BaseCommand
{
    private readonly TelegramBotClient _telegramBotClient;
    private readonly IServiceAddressRepository _serviceAddressRepository;
    private readonly Dictionary<Enum, string> _districtDict;
    
    private int _messageSplitterPortionSize;
    private TelegramBotSettings _telegramBotSettings;
    
    /// <summary>
    /// Конструктор
    /// </summary>
    public ShowServiceAddressInfoCommand(TelegramBot telegramBot, IServiceScopeFactory serviceScopeFactory)
    {
        var scope = serviceScopeFactory.CreateScope();
        _districtDict = new Dictionary<Enum, string>
        {
            { DistrictEnum.Okt, "okt-district" },
            { DistrictEnum.Jlz, "jlz-district" },
            { DistrictEnum.Cen, "cen-district" },
            { DistrictEnum.Sov, "sov-district" },
            { DistrictEnum.Kir, "kir-district" },
            { DistrictEnum.Sve, "sve-district" },
            { DistrictEnum.Len, "len-district" }
        };
        
        _serviceAddressRepository = scope.ServiceProvider.GetRequiredService<IServiceAddressRepository>();
        _telegramBotSettings = scope.ServiceProvider.GetRequiredService<IOptionsMonitor<TelegramBotSettings>>().CurrentValue
                               ?? throw new ArgumentNullException("Telegram bot settings must be not null");
        scope.ServiceProvider.GetRequiredService<IOptionsMonitor<TelegramBotSettings>>()
            .OnChange(settings =>
            {
                _telegramBotSettings.MessageSplitterPortionSize = settings.MessageSplitterPortionSize;
                _messageSplitterPortionSize = settings.MessageSplitterPortionSize;
            });
        _messageSplitterPortionSize = _telegramBotSettings.MessageSplitterPortionSize;
        _telegramBotClient = telegramBot.GetTelegramBotClient().Result;
    }
    
    public override string Name => CommandNames.ShowDistrictServiceAddressDataCommand;
    public override async Task ExecuteAsync(Update update)
    {
        var serviceAddresses = await _serviceAddressRepository.GetLatestServiceAddressAsync(default).ConfigureAwait(false);
        if (!serviceAddresses.Any())
        {
            await _telegramBotClient.SendMessage(update.Message.Chat.Id, "В данный момент нет сообщений об отключении", ParseMode.Markdown);
        }
        else
        {
            var districtEnum = _districtDict.FirstOrDefault(x => x.Value.Equals(update.CallbackQuery.Data));
            if (districtEnum.Key is null)
            {
                await SendSplitterServiceAddressesList(serviceAddresses, update);
                return;
            }

            var filteredServiceAddressData = new List<ServiceAddress>();
            switch (districtEnum.Key)
            {
                case DistrictEnum.Okt:
                    filteredServiceAddressData = FilterServiceAddressList(DistrictEnum.Okt.GetGuidValue(), serviceAddresses);
                    break;
                case DistrictEnum.Jlz:
                    filteredServiceAddressData = FilterServiceAddressList(DistrictEnum.Jlz.GetGuidValue(), serviceAddresses);
                    break;
                case DistrictEnum.Cen:
                    filteredServiceAddressData = FilterServiceAddressList(DistrictEnum.Cen.GetGuidValue(), serviceAddresses);
                    break;
                case DistrictEnum.Sov:
                    filteredServiceAddressData = FilterServiceAddressList(DistrictEnum.Sov.GetGuidValue(), serviceAddresses);
                    break;
                case DistrictEnum.Kir:
                    filteredServiceAddressData = FilterServiceAddressList(DistrictEnum.Kir.GetGuidValue(), serviceAddresses);
                    break;
                case DistrictEnum.Sve:
                    filteredServiceAddressData = FilterServiceAddressList(DistrictEnum.Sve.GetGuidValue(), serviceAddresses);
                    break;
                case DistrictEnum.Len:
                    filteredServiceAddressData = FilterServiceAddressList(DistrictEnum.Len.GetGuidValue(), serviceAddresses);
                    break;
            }

            if (!filteredServiceAddressData.Any())
            {
                await _telegramBotClient.SendMessage(update.CallbackQuery.Message.Chat.Id, $"Для {districtEnum.Key.GetDescriptionValue()} не найдено отключений", ParseMode.Markdown);
                return;
            }
            await SendSplitterServiceAddressesList(filteredServiceAddressData, update).ConfigureAwait(false);
        }
    }

    /// <summary>
    /// Отфильтровать отключения по району
    /// </summary>
    /// <returns></returns>
    private List<ServiceAddress> FilterServiceAddressList(Guid districtId, List<ServiceAddress> targetList)
    {
        return targetList
            .Where(x => x.DistrictId == districtId)
            .OrderBy(x => x.DistrictId)
            .ThenBy(x => x.StreetId)
            .ThenByDescending(x => x.DateTimeFromString)
            .ToList();
    }


    /// <summary>
    /// Разделяет список на части для обхода ограничения телеграм в 4096 символов
    /// </summary>
    /// <param name="serviceAddresses"></param>
    /// <param name="update"></param>
    /// <returns></returns>
    private async Task SendSplitterServiceAddressesList(List<ServiceAddress> serviceAddresses, Update update)
    {
        var currentAddressListPrinted = 0;
        while (currentAddressListPrinted <= serviceAddresses.Count)
        {
            var partFiltereedServiceAddressData = serviceAddresses
                .Skip(currentAddressListPrinted)
                .Take(_messageSplitterPortionSize)
                .ToList();
            var filteredPayload = BuildPayloadString(partFiltereedServiceAddressData);
            if (string.IsNullOrEmpty(filteredPayload))
            {
                return;
            }
            await _telegramBotClient.SendMessage(update.CallbackQuery.Message.Chat.Id, filteredPayload, ParseMode.Markdown);
            currentAddressListPrinted += _messageSplitterPortionSize;
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