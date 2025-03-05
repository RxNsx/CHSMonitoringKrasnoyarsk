using CHSMonitoring.Application.Dtos.Geocode;
using CHSMonitoring.Application.Queries.Geocode;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CHSMonitoring.API.Controllers;

/// <summary>
/// Контроллер получения геоданных по адресу
/// </summary>
[Route("/api/[controller]")]
[ApiController()]
public class GeocodeController : ControllerBase
{
    private readonly IMediator _mediator;

    /// <summary>
    /// Конструктор
    /// </summary>
    public GeocodeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Получить список координат по районам
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("[action]")]
    [ProducesResponseType<ServiceAddressGeoLocationDto>(200)]
    public async Task<IActionResult> GetDistrictGeoCoordinates([FromQuery] string districtId, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new GetDistrictGeoCoordinatesQuery(districtId), cancellationToken)
            .ConfigureAwait(false);
        if (!result.IsSuccess)
        {
            return BadRequest($"Ошибка при получении геоданных");
        }
        
        return Ok(result.Value);
    }
}