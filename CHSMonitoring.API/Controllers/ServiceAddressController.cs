using CHSMonitoring.Application.Queries.ServiceAddresses.Get;
using CHSMonitoring.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CHSMonitoring.API.Controllers;

[ApiController]
[Route("api/[controller]es")]
public class ServiceAddressController : ControllerBase
{
    private readonly ISender _sender;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="sender"></param>
    public ServiceAddressController(ISender sender)
    {
        _sender = sender;
    }

    /// <summary>
    /// Получить информацию по адрсу с названием улицы и номером дома
    /// </summary>
    /// <param name="streetName"></param>
    /// <param name="houseNumber"></param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType<List<ServiceAddress>>(200, contentType: "application/json")]
    [ProducesResponseType<List<ServiceAddress>>(400, contentType: "application/json")]
    public async Task<IActionResult> GetServiceAddress(string streetName, string houseNumber)
    {
        var result = await _sender.Send(new GetServiceAddressQuery(streetName, houseNumber))
            .ConfigureAwait(false);
        
        return Ok();
    }
}