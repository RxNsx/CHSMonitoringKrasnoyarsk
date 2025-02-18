﻿using Telegram.Bot.Types;

namespace CHSMonitoring.Infrastructure.Models.TelegramBot;

/// <summary>
/// Базовая команда
/// </summary>
public abstract class BaseCommand
{
    public abstract string Name { get; }
    public abstract Task ExecuteAsync(Update update);
}