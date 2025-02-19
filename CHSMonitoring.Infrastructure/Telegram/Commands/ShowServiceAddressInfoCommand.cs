using System.Text;
using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Domain.Enums;
using CHSMonitoring.Infrastructure.Abstractions.Telegram;
using CHSMonitoring.Infrastructure.Common;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Models.Enums;
using Microsoft.Extensions.DependencyInjection;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CHSMonitoring.Infrastructure.Telegram.Commands;

public sealed class ShowServiceAddressInfoCommand : BaseCommand
{
    private readonly TelegramBotClient _telegramBotClient;
    private readonly IServiceAddressRepository _serviceAddressRepository;
    private readonly Dictionary<Enum, string> _districtDict;

    /// <summary>
    /// Конструктор
    /// </summary>
    public ShowServiceAddressInfoCommand(Telegram.TelegramBot telegramBot, IServiceScopeFactory serviceScopeFactory)
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
                var currentAddressListPrinted1 = 0;
                while (currentAddressListPrinted1 <= serviceAddresses.Count)
                {
                    List<ServiceAddress> partFiltereedServiceAddressData = new();
                    if (serviceAddresses.Count - 30 >= 0)
                    {
                        partFiltereedServiceAddressData = serviceAddresses.Take(30)
                            .Skip(currentAddressListPrinted1)
                            .ToList();
                    }
                    else
                    {
                        partFiltereedServiceAddressData = serviceAddresses
                            .Take(serviceAddresses.Count - currentAddressListPrinted1)
                            .Skip(currentAddressListPrinted1)
                            .ToList();
                    }
                    var filteredPayload = BuildPayloadString(partFiltereedServiceAddressData);
                    if (string.IsNullOrEmpty(filteredPayload))
                    {
                        return;
                    }
                    
                    await _telegramBotClient.SendMessage(update.CallbackQuery.Message.Chat.Id, filteredPayload, ParseMode.Markdown);
                    currentAddressListPrinted1 += 30;
                }
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

            var currentAddressListPrinted = 0;
            while (currentAddressListPrinted <= filteredServiceAddressData.Count)
            {
                var partFiltereedServiceAddressData = filteredServiceAddressData.Take(30)
                    .Skip(currentAddressListPrinted)
                    .ToList();
                var filteredPayload = BuildPayloadString(partFiltereedServiceAddressData);
                if (string.IsNullOrEmpty(filteredPayload))
                {
                    return;
                }
                await _telegramBotClient.SendMessage(update.CallbackQuery.Message.Chat.Id, filteredPayload, ParseMode.Markdown);
                currentAddressListPrinted += 30;
            }
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
            .ToList();
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
                sb.AppendLine().AppendLine(serviceTypeName).AppendLine();
                
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