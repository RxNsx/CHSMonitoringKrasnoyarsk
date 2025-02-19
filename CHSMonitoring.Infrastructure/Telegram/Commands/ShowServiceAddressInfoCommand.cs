using System.Text;
using CHSMonitoring.Domain.Entities;
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
                var payload = BuildPayloadString(serviceAddresses);
                await _telegramBotClient.SendMessage(update.CallbackQuery.Message.Chat.Id, payload, ParseMode.Markdown);
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

            var filteredPayload = BuildPayloadString(filteredServiceAddressData);
            await _telegramBotClient.SendMessage(update.CallbackQuery.Message.Chat.Id, filteredPayload, ParseMode.Markdown);
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
        var sb = new StringBuilder();
        foreach (var serviceAddress in targetList)
        {
            var streetName = CommonData.StreetsData.FirstOrDefault(x => x.Id == serviceAddress.StreetId).StreetName;
            var serviceType = CommonData.ServiceTypesData.FirstOrDefault(x => x.Id == serviceAddress.ServiceTypeId).ServiceTypeName;
            sb.AppendLine($"{serviceType}, {streetName}, {serviceAddress.HouseNumber}, {serviceAddress.DateTimeFromString}, {serviceAddress.DateTimeToString}, ");
        }

        return sb.ToString();
    }
}