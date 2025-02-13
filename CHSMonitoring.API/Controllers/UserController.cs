using CHSMonitoring.Application.Commands.User.Register;
using CHSMonitoring.Application.Dtos.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CHSMonitoring.API.Controllers;

/// <summary>
/// Контроллер пользователей
/// </summary>
[Route("/api/[controller]s")]
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
}