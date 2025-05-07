using CHSMonitoring.Application.Commands.TelegramBot;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;

namespace CHSMonitoring.API.Controllers;

/// <summary>
/// Контроллер для обработки сообщенй от пользователей телеграмма
/// </summary>
[Route("/api/[controller]")]
[ApiController]
public class TelegramBotController : ControllerBase
{
    private readonly IMediator _mediator;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="mediator"></param>
    public TelegramBotController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Получение обновления со стороны Telegram - сервера
    /// </summary>
    /// <param name="update"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> UpdateAsync([FromBody] Update update)
    {
        await _mediator.Send(new TelegramBotCommand(update)).ConfigureAwait(false);
        return Ok();
    }
}