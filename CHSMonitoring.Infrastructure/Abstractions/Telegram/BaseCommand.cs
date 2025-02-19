using Telegram.Bot.Types;

namespace CHSMonitoring.Infrastructure.Abstractions.Telegram;

/// <summary>
/// Базовая команда
/// </summary>
public abstract class BaseCommand
{
    public abstract string Name { get; }
    public abstract Task ExecuteAsync(Update update);
}