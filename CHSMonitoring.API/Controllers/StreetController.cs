using CHSMonitoring.Application.Dtos.Streets;
using CHSMonitoring.Application.Queries.Streets;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CHSMonitoring.API.Controllers;

/// <summary>
/// Контроллер улиц
/// </summary>
[ApiController]
[Route("/api/[controller]")]
public class StreetsController : ControllerBase
{
    private readonly IMediator _mediator;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="mediator"></param>
    public StreetsController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    /// <summary>
    /// Получить все улицы
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("[action]")]
    [ProducesResponseType<List<StreetDto>>(200)]
    public async Task<IActionResult> GetAllStreetsAsync(CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new GetAllStreetsQuery(), cancellationToken)
            .ConfigureAwait(false);
        return Ok(result);
    }
}