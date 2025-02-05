using CHSMonitoring.Application.Queries.ServiceAddresses.Get;
using CHSMonitoring.Application.Queries.ServiceAddresses.GetList;
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
    [HttpGet("[action]")]
    [ProducesResponseType<List<ServiceAddress>>(200, contentType: "application/json")]
    [ProducesResponseType<List<ServiceAddress>>(400, contentType: "application/json")]
    public async Task<IActionResult> GetServiceAddress([FromQuery] string streetName, string houseNumber)
    {
        var result = await _sender.Send(new GetServiceAddressQuery(streetName, houseNumber))
            .ConfigureAwait(false);
        return Ok();
    }

    [HttpGet("[action]")]
    [ProducesResponseType<List<ServiceAddress>>(200, contentType: "application/json")]
    [ProducesResponseType<List<ServiceAddress>>(400, contentType: "application/json")]
    public async Task<IActionResult> GetServiceAddresesByStreetNames([FromQuery] List<string> streetNames)
    {
        var result = await _sender.Send(new GetServiceAddressListQuery(streetNames))
            .ConfigureAwait(false);
        return Ok();
    }
}