using CHSMonitoring.Application.Commands.Login;
using CHSMonitoring.Application.Dtos.Login;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CHSMonitoring.API.Controllers;

/// <summary>
/// Контроллер авторизации пользователя
/// </summary>
[Route("/api/[controller]")]
[ApiController]
public class LoginController : ControllerBase
{
    private readonly IMediator _mediator;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="mediator"></param>
    public LoginController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [Route("[action]")]
    [ProducesResponseType<LoginUserDto>(200)]
    public async Task<IActionResult> LoginUserAsync([FromBody]LoginItemDto loginItem,  CancellationToken cancellationToken)
    {
        var loginResult = await _mediator.Send(new LoginUserCommand(loginItem.LoginName, loginItem.Password), cancellationToken);
        if (!loginResult.IsSuccess)
        {
            return BadRequest(loginResult.Error.Text);
        }

        return Ok(loginResult.Value);
    }
}