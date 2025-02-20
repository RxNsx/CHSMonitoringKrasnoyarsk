﻿using CHSMonitoring.Infrastructure.Abstractions.Telegram;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CHSMonitoring.Infrastructure.Telegram.Commands;

/// <summary>
/// Команда пользователя с таким адресом электронной почты уже зарегистрирована
/// </summary>
public sealed class UserEmailAlreadyExistsCommand : BaseCommand
{
    private TelegramBotClient _telegramBotClient;

    /// <summary>
    /// Конструктор
    /// </summary>
    public UserEmailAlreadyExistsCommand(Telegram.TelegramBot telegramBot)
    {
        _telegramBotClient = telegramBot.GetTelegramBotClient().Result;
    }

    public override string Name => CommandNames.UserEmailAlreadyExists;
    public override async Task ExecuteAsync(Update update)
    {
        await _telegramBotClient.SendMessage(update.Message.Chat.Id, "Пользователь с таким адресом электронной почты уже зарегистрирован. Введите другой адрес", ParseMode.Markdown);
    }
}