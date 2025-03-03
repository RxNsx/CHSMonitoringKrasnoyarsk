using CHSMonitoring.Application.Commands.User.Register;
using CHSMonitoring.Application.Dtos.User;
using CHSMonitoring.Application.Queries.User.Get;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CHSMonitoring.API.Controllers;

/// <summary>
/// Контроллер пользователей
/// </summary>
[Route("/api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="mediator"></param>
    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    /// <summary>
    /// Регистрация пользователя в системе
    /// </summary>
    /// <param name="registerItem"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("[action]")]
    [ProducesResponseType<RegisterUserDto>(200)]
    public async Task<IActionResult> RegisterUserAsync([FromBody] RegisterItemDto registerItem, CancellationToken cancellationToken)
    {
        var registerResult = await _mediator.Send(new RegisterUserCommand(registerItem.UserName, registerItem.LoginName, registerItem.Password, registerItem.Email),
                cancellationToken);
        if (!registerResult.IsSuccess)
        {
            return BadRequest(registerResult.Error.Text);
        }
        
        return Ok(registerResult.Value);
    }

    [HttpGet]
    [Route("[action]")]
    [ProducesResponseType<GetUserDto>(200)]
    public async Task<IActionResult> GetUserAsync([FromQuery] string loginName, CancellationToken cancellationToken)
    {
        var userResult = await _mediator.Send(new GetUserQuery(loginName), cancellationToken).ConfigureAwait(false);
        if (!userResult.IsSuccess)
        {
            return BadRequest(userResult.Error.Text);
        }

        return Ok(userResult.Value);
    }
}