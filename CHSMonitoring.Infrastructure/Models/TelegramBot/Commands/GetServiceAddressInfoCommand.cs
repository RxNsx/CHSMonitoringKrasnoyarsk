using System.Text;
using CHSMonitoring.Infrastructure.Common;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Models.TelegramBot.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CHSMonitoring.Infrastructure.Models.TelegramBot.Commands;

public sealed class GetServiceAddressInfoCommand : BaseCommand
{
    private readonly TelegramBotClient _telegramBotClient;
    private readonly IServiceAddressRepository _serviceAddressRepository;

    /// <summary>
    /// Конструктор
    /// </summary>
    public GetServiceAddressInfoCommand(Telegram.TelegramBot telegramBot, IServiceScopeFactory serviceScopeFactory)
    {
        var scope = serviceScopeFactory.CreateScope();
        _serviceAddressRepository = scope.ServiceProvider.GetRequiredService<IServiceAddressRepository>();
        _telegramBotClient = telegramBot.GetTelegramBotClient().Result;
    }
    
    public override string Name => CommandNames.GetServiceAddressInfo;
    public override async Task ExecuteAsync(Update update)
    {
        var serviceAddresses = await _serviceAddressRepository.GetLatestServiceAddressAsync(default).ConfigureAwait(false);
        if (!serviceAddresses.Any())
        {
            await _telegramBotClient.SendMessage(update.Message.Chat.Id, "В данный момент нет сообщений об отключении", ParseMode.Markdown);
        }
        else
        {
            var grouped = serviceAddresses
                .GroupBy(x => x.DistrictId)
                .ToDictionary(x => x.Key, x => x.ToList());

            StringBuilder sb = new();
            sb.AppendLine("Отключение по районам");
            foreach (var group in grouped)
            {
                var districtName = CommonData.DistrictsData.FirstOrDefault(x => x.Id == group.Key).DistrictName;
                sb.AppendLine(string.Empty).AppendLine($"{districtName}").AppendLine(string.Empty);

                foreach (var item in grouped[group.Key])
                {
                    var streetName = CommonData.StreetsData.FirstOrDefault(x => x.Id == item.StreetId).StreetName;
                    var serviceType = CommonData.ServiceTypesData.FirstOrDefault(x => x.Id == item.ServiceTypeId).ServiceTypeName;
                    sb.AppendLine($"{serviceType}, {streetName}, {item.HouseNumber}, {item.DateTimeFromString}, {item.DateTimeToString}, ");
                }
            }

            await _telegramBotClient.SendMessage(update.Message.Chat.Id, sb.ToString(), ParseMode.Markdown);
        }
    }
}