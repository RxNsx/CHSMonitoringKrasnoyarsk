using System.Text.Json.Nodes;
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
    private readonly TelegramBotClient _telegramBotClient;

    public TelegramBotController(TelegramBot telegramBot)
    {
        _telegramBotClient = telegramBot.GetTelegramBotClient().Result;
    }

    
    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> UpdateAsync([FromBody] Update update)
    {
        if (update.Message is null || update.Message.Text is null || update?.Message.Chat is null)
        {
            return Ok();
        }
        
        var text = update.Message.Text;
        var chat = update.Message?.Chat;
        if (text.Equals("/start", StringComparison.InvariantCultureIgnoreCase))
        {
            await _telegramBotClient.SendMessage(chat.Id, "Start", ParseMode.Markdown)
                .ConfigureAwait(false);
        }
        if (text.Equals("hello", StringComparison.InvariantCultureIgnoreCase))
        {
            await _telegramBotClient.SendMessage(chat.Id, "Booba", ParseMode.Markdown)
                .ConfigureAwait(false);
        }

        return Ok();
    }
}