using CHSMonitoring.Application.Dtos.District;
using CHSMonitoring.Application.Queries.Districts.Get;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CHSMonitoring.API.Controllers;

/// <summary>
/// Контроллер информации по районам 
/// </summary>
[Route("/api/[controller]s")]
[ApiController]
public class DistrictController : ControllerBase
{
    private readonly IMediator _mediator;
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="mediator"></param>
    public DistrictController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Получение районов
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("[action]")]
    [ProducesResponseType<List<DistrictDto>>(200)]
    public async Task<IActionResult> GetDistrictsAsync(CancellationToken cancellationToken)
    {
        var districtsResult = await _mediator.Send(new GetDistrictsQuery(), cancellationToken).ConfigureAwait(false);
        if (!districtsResult.IsSuccess)
        {
            return BadRequest(districtsResult.Error.Text);
        }

        return Ok(districtsResult.Value);
    }
}