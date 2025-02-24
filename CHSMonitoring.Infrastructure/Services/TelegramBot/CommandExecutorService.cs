using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Domain.Enums;
using CHSMonitoring.Infrastructure.Abstractions.Telegram;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Interfaces.TelegramBot;
using CHSMonitoring.Infrastructure.Models.Enums;
using CHSMonitoring.Infrastructure.Telegram;
using CHSMonitoring.Infrastructure.Telegram.Dtos;
using Microsoft.Extensions.DependencyInjection;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CHSMonitoring.Infrastructure.Services.TelegramBot;

/// <summary>
/// Сервис обработки команд для телеграм бота
/// </summary>
public class CommandExecutorService : ICommandExecutorService
{
    private readonly IProfileRepository _profileRepository;
    private readonly IUserRepository _userRepository;
    private readonly ISubscriptionRepository _subscriptionRepository;
    private readonly List<BaseCommand> _baseCommands;
    private readonly List<SendMessageCommand> _sendMessageCommands;
    
    private CommandState _commandState;
    private RegisterTelegramUserDto _registerUser;
    private Subscription _newSubscription;
    private Subscription _editSubscription;

    /// <summary>
    /// Конструктор
    /// </summary>
    public CommandExecutorService(IServiceProvider serviceProvider, IServiceScopeFactory serviceScopeFactory)
    {
        var scope = serviceScopeFactory.CreateScope();
        _userRepository = scope.ServiceProvider.GetRequiredService<IUserRepository>();
        _profileRepository = scope.ServiceProvider.GetRequiredService<IProfileRepository>();
        _subscriptionRepository = scope.ServiceProvider.GetRequiredService<ISubscriptionRepository>();
        _baseCommands = serviceProvider.GetServices<BaseCommand>().ToList();
        _sendMessageCommands = serviceProvider.GetServices<SendMessageCommand>().ToList();
        _registerUser = new RegisterTelegramUserDto();
    }
    
    /// <summary>
    /// Выполнение команды
    /// </summary>
    /// <param name="update"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task Execute(Update update)
    {
        try
        {
            if (update.Type == UpdateType.Message)
            {
                if (update?.Message is null)
                {
                    return;
                }

                await HandleExecuteUpdateMessage(update).ConfigureAwait(false);
            }
            if (update.Type == UpdateType.CallbackQuery)
            {
                if (update?.CallbackQuery is null)
                {
                    return;
                }

                await HandleExecuteUpdateCallbackQuery(update).ConfigureAwait(false);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    /// <summary>
    /// Обработка сообщений типа Message
    /// </summary>
    /// <param name="update"></param>
    public async Task HandleExecuteUpdateMessage(Update update)
    {
        switch (_commandState)
        {
            case CommandState.NotActive:
            {
                switch (update!.Message?.Text)
                {
                    case CommandNames.StartCommand:
                    {
                        var isProfileExists = await _profileRepository.IsTelegramProfileAsync(update.Message.From.Id);
                        if (!isProfileExists)
                        {
                            await ExecuteCommand(CommandNames.StartCommand, update).ConfigureAwait(false);
                        }
                        else
                        {
                            await ExecuteCommand(CommandNames.ShowDistrictButtonsList, update).ConfigureAwait(false);
                        }
                        break;
                    }
                    case CommandNames.ShowButtonsCommand:
                    {
                        await ExecuteCommand(CommandNames.ShowDistrictButtonsList, update).ConfigureAwait(false);
                        break;
                    }
                    case CommandNames.SubscriptionCommand:
                    {
                        var user = await _userRepository.GetUserByTelegramProfileIdAsync(update.Message.From.Id, default).ConfigureAwait(false);
                        if (user is null)
                        {
                            await ExecuteSendMessageCommand(CommandNames.SendUserMessage, "Авторизуйтесь для настройки подписки!", UpdateType.Message, update).ConfigureAwait(false);
                            await ExecuteCommand(CommandNames.StartCommand, update).ConfigureAwait(false);
                        }
                        
                        var isSubscribeExists = await _subscriptionRepository
                            .IsSubscribeExistsAsync(update.Message.From.Id, ProfileTypeEnum.Telegram, default)
                            .ConfigureAwait(false);
                        if (!isSubscribeExists)
                        {
                            var userByProfile = await  _userRepository.GetUserByTelegramProfileIdAsync(update.Message.From.Id, default).ConfigureAwait(false);
                            _newSubscription = new Subscription();
                            _newSubscription.UserId = userByProfile!.Id;
                            await ExecuteCommand(CommandNames.StartSubscribeProcess, update).ConfigureAwait(false);
                        }
                        else
                        {
                            await ExecuteCommand(CommandNames.ShowSubscriptionDetailsCommand, update).ConfigureAwait(false);
                        }
                        break;
                    }
                }

                break;
            }
            case CommandState.AuthrorizeStart:
            {
                await ExecuteSendMessageCommand(CommandNames.SendUserMessage, "Введите адрес электронной почты", UpdateType.Message, update).ConfigureAwait(false);
                _registerUser.Name = update.Message.Text;
                _commandState = CommandState.AuthorizeUserNameSet;
                break;
            }
            case CommandState.AuthorizeUserNameSet:
            {
                _registerUser.EmailAddress = update.Message.Text;
                if (!update.Message!.Text.IsEmailValid())
                {
                    await ExecuteSendMessageCommand(CommandNames.SendUserMessage, "Ошибка в почтовом адресе, попробуйте снова", UpdateType.Message, update).ConfigureAwait(false);
                }
                else
                {
                    try
                    {
                        var isUserEmailExists = await _userRepository.GetUserByUserEmailAddressAsync(_registerUser.EmailAddress, default);
                        if (isUserEmailExists is not null)
                        {
                            await ExecuteSendMessageCommand(CommandNames.SendUserMessage, "Пользователь с таким адресом электронной почты уже зарегистрирован. Введите другой адрес", UpdateType.Message, update).ConfigureAwait(false);
                            _registerUser.EmailAddress = string.Empty;
                            break;
                        }

                        await _userRepository.CreateTelegramUserAsync(update.Message.From.Id, _registerUser.Name, update.Message.From.Username, _registerUser.EmailAddress, default).ConfigureAwait(false);
                        await ExecuteSendMessageCommand(CommandNames.SendUserMessage, "Вы успешно авторизовались", UpdateType.Message, update).ConfigureAwait(false);
                        await ExecuteCommand(CommandNames.ShowDistrictButtonsList, update).ConfigureAwait(false);
                        _commandState = CommandState.NotActive;
                    }
                    catch (Exception ex)
                    {
                        await ExecuteSendMessageCommand(CommandNames.SendErrorCommand, ex.Message, UpdateType.Message, update).ConfigureAwait(false);
                    }
                }
                break;
            }
        }
    }

    /// <summary>
    /// Обработка сообщений типа Callback
    /// </summary>
    /// <param name="update"></param>
    public async Task HandleExecuteUpdateCallbackQuery(Update update)
    {
        switch (_commandState)
        {
            case CommandState.NotActive:
            {
                switch (update.CallbackQuery.Data)
                {
                    case CommandNames.StartAuthorizeProcess:
                    {
                        _commandState = CommandState.AuthrorizeStart;
                        await ExecuteSendMessageCommand(CommandNames.SendUserMessage, "Введите имя пользователя", UpdateType.CallbackQuery, update);
                        break;
                    }
                    case var _ when update.CallbackQuery.Data.Contains("-district-list"):
                    {
                        await ExecuteCommand(CommandNames.ShowDistrictServiceAddressDataCommand, update).ConfigureAwait(false);
                        update.Message = update.CallbackQuery.Message;
                        await ExecuteCommand(CommandNames.ShowDistrictButtonsList, update).ConfigureAwait(false);
                        break;
                    }
                    case CommandNames.StartSubscribeProcess:
                    {
                        _commandState = CommandState.SubscribeStart;
                        await ExecuteCommand(CommandNames.ShowDistrictButtonsSubscription, update).ConfigureAwait(false);
                        break;
                    }
                    case CommandNames.ShowSubscriptionDetailsCommand:
                    {
                        await ExecuteCommand(CommandNames.ShowSubscriptionDetailsCommand, update).ConfigureAwait(false);
                        break;
                    }
                    case CommandNames.ChangeSubscription:
                    {
                        var userByProfile = await  _userRepository.GetUserByTelegramProfileIdAsync(update.CallbackQuery.From.Id, default).ConfigureAwait(false);
                        _editSubscription = new Subscription();
                        _editSubscription.UserId = userByProfile!.Id;
                        await ExecuteCommand(CommandNames.ShowDistrictButtonsSubscription, update).ConfigureAwait(false);
                        _commandState = CommandState.EditSubscribeChangeDistrict;
                        break;
                    }
                }
                break;
            }
            case CommandState.SubscribeStart:
            {
                switch (update.CallbackQuery.Data)
                {
                    case var _
                        when update.CallbackQuery.Data.Contains("-district-subscribe"):
                    {
                        _newSubscription.DistrictId = GetDistrictNameByCallbackData(update.CallbackQuery.Data);
                        _commandState = CommandState.SubscribeDistrictSet;
                        await ExecuteCommand(CommandNames.ShowUserTimeIntervalRefresh, update).ConfigureAwait(false);
                        break;
                    }
                }
                break;
            }
            case CommandState.SubscribeDistrictSet:
            {
                switch (update.CallbackQuery.Data)
                {
                    case var _
                        when update.CallbackQuery.Data.Contains("-refresh-interval"):
                    {
                        _newSubscription.UpdateUserTime = GetTimeIntervalValueByCallbackData(update.CallbackQuery.Data);
                        await _subscriptionRepository.AddSubscriptionAsync(_newSubscription, default).ConfigureAwait(false);
                        await ExecuteCommand(CommandNames.ShowSubscriptionDetailsCommand, update).ConfigureAwait(false);
                        _commandState = CommandState.NotActive;
                        break;
                    }
                }
                break;
            }
            case CommandState.EditSubscribeChangeDistrict:
            {
                switch (update.CallbackQuery.Data)
                {
                    case var _
                        when update.CallbackQuery.Data.Contains("-district-subscribe"):
                    {
                        _editSubscription.DistrictId = GetDistrictNameByCallbackData(update.CallbackQuery.Data);
                        await ExecuteCommand(CommandNames.ShowUserTimeIntervalRefresh, update);
                        _commandState = CommandState.EditSubscribeChangeInterval;
                        break;
                    }
                }

                break;
            }
            case CommandState.EditSubscribeChangeInterval:
            {
                switch (update.CallbackQuery.Data)
                {
                    case var _
                        when update.CallbackQuery.Data.Contains("-refresh-interval"):
                    {
                        _editSubscription.UpdateUserTime = GetTimeIntervalValueByCallbackData(update.CallbackQuery.Data);
                        var updatedSubscription = await _subscriptionRepository.UpdateSubscriptionAsync(_editSubscription, update.CallbackQuery.From.Id, ProfileTypeEnum.Telegram, default).ConfigureAwait(false);
                        _commandState = CommandState.NotActive;
                        await ExecuteCommand(CommandNames.ShowSubscriptionDetailsCommand, update).ConfigureAwait(false);
                        break;
                    }
                }
                break;
            }
        }
    }

    /// <summary>
    /// Базовое выполнение команды
    /// </summary>
    /// <param name="commandName"></param>
    /// <param name="update"></param>
    private async Task ExecuteCommand(string commandName, Update update)
    {
        var baseCommand = _baseCommands.First(x => x.Name == commandName);
        await baseCommand.ExecuteAsync(update);
    }

    /// <summary>
    /// Выполнить команду отправки сообщения
    /// </summary>
    /// <param name="commandName"></param>
    /// <param name="message"></param>
    /// <param name="updateType"></param>
    /// <param name="update"></param>
    private async Task ExecuteSendMessageCommand(string commandName, string message, UpdateType updateType, Update update)
    {
        var sendMessageCommand = _sendMessageCommands.First(x => x.Name == commandName);
        await sendMessageCommand.ExecuteAsync(message, updateType, update);
    }

    /// <summary>
    /// Получить район из CallbackQuery вызова по кнопке
    /// </summary>
    /// <param name="districtString"></param>
    /// <returns></returns>
    private Guid GetDistrictNameByCallbackData(string districtString)
    {
        var districtPureString = districtString.Replace("-district-subscribe", string.Empty);
        var districtIntValue = int.Parse(districtPureString);
        var districtId = Enum.GetValues(typeof(DistrictEnum))
            .Cast<DistrictEnum>()
            .Where(x => (int)x == districtIntValue)
            .Select(x => x.GetGuidValue())
            .FirstOrDefault();

        return districtId;
    }

    /// <summary>
    /// Получить интервал из CallbackQuery вызова по кнопке
    /// </summary>
    /// <param name="intervalString"></param>
    /// <returns></returns>
    private int GetTimeIntervalValueByCallbackData(string? intervalString)
    {
        var pureString = intervalString.Replace("-refresh-interval", string.Empty);
        var intValue = int.Parse(pureString);
        return intValue;
    }
}