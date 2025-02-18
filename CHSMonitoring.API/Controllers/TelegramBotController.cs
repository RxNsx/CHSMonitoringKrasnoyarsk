using System.Text.Json.Nodes;
using CHSMonitoring.Infrastructure.Interfaces.TelegramBot;
using CHSMonitoring.Infrastructure.Telegram;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CHSMonitoring.API.Controllers;

/// <summary>
/// Контроллер для обработки сообщенй от пользователей телеграмма
/// </summary>
[Route("/api/[controller]")]
[ApiController]
public class TelegramBotController : ControllerBase
{
    private readonly ICommandExecutorService _commandExecutorService;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="commandExecutorService"></param>
    public TelegramBotController(ICommandExecutorService commandExecutorService)
    {
        _commandExecutorService = commandExecutorService;
    }

    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> UpdateAsync([FromBody] Update update)
    {
        await _commandExecutorService.Execute(update).ConfigureAwait(false);
        return Ok();
    }
}