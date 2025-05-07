using CHSMonitoring.Infrastructure.Interfaces.TelegramBot;
using MediatR;

namespace CHSMonitoring.Application.Commands.TelegramBot;

/// <summary>
/// Обработчик команды Telegram
/// </summary>
public class TelegramBotCommandHandler : IRequestHandler<TelegramBotCommand>
{
    private readonly ICommandExecutorService _commandExecutorService;
    
    /// <summary>
    /// Конструктор
    /// </summary>
    public TelegramBotCommandHandler(ICommandExecutorService commandExecutorService)
    {
        _commandExecutorService = commandExecutorService;
    }
    
    public async Task Handle(TelegramBotCommand request, CancellationToken cancellationToken)
    {
        await _commandExecutorService.Execute(request.Update).ConfigureAwait(false);
    }
}