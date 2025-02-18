﻿using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Interfaces.TelegramBot;
using CHSMonitoring.Infrastructure.Models.TelegramBot;
using CHSMonitoring.Infrastructure.Models.TelegramBot.Dtos;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
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
    private readonly List<BaseCommand> _commands;
    private CommandState _commandState;
    private BaseCommand _lastExecutedCommand;
    private RegisterTelegramUserDto _registerUser;

    /// <summary>
    /// Конструктор
    /// </summary>
    public CommandExecutorService(IServiceProvider serviceProvider, IServiceScopeFactory serviceScopeFactory)
    {
        var scope = serviceScopeFactory.CreateScope();
        _userRepository = scope.ServiceProvider.GetRequiredService<IUserRepository>();
        _profileRepository = scope.ServiceProvider.GetRequiredService<IProfileRepository>();
        _commands = serviceProvider.GetServices<BaseCommand>().ToList();
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
        if (update.Type == UpdateType.Message)
        {
            if (update?.Message is null)
            {
                return;
            }

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
                            break;
                        }
                    }
                    
                    break;
                }
                case CommandState.AuthrorizeStart:
                {
                    await ExecuteCommand(CommandNames.SetEmailAddressCommand, update).ConfigureAwait(false);
                    _registerUser.Name = update.Message.Text;
                    _commandState = CommandState.AuthorizeUserNameSet;
                    break;
                }
                case CommandState.AuthorizeUserNameSet:
                {
                    _registerUser.EmailAddress = update.Message.Text;
                    if (!update.Message!.Text.IsEmailValid())
                    {
                        await ExecuteCommand(CommandNames.ResentEmailAddress, update).ConfigureAwait(false);
                        break;
                    }
                    else
                    {
                        try
                        {
                            await _userRepository
                                .CreateTelegramUserAsync(update.Message.From.Id, _registerUser.Name, update.Message.From.Username, _registerUser.EmailAddress, default)
                                .ConfigureAwait(false);
                            await ExecuteCommand(CommandNames.SuccessAuthorization, update);
                            _commandState = CommandState.NotActive;
                        }
                        catch (Exception ex)
                        {
                            
                        }

                        break;
                    }
                }
            }
        }

        if (update.Type == UpdateType.CallbackQuery)
        {
            if (update?.CallbackQuery?.Data is null)
            {
                return;
            }

            switch (_commandState)
            {
                case CommandState.NotActive:
                {
                    switch (update.CallbackQuery.Data)
                    {
                        case CommandNames.StartAuthorizeProcess:
                        {
                            _commandState = CommandState.AuthrorizeStart;
                            await ExecuteCommand(CommandNames.SetUserNameCommand, update);
                            break;
                        }
                    }
                    
                    break;
                }
            }
        }
    }

    private async Task ExecuteCommand(string commandName, Update update)
    {
        _lastExecutedCommand = _commands.First(x => x.Name == commandName);
        await _lastExecutedCommand.ExecuteAsync(update);
    }
}