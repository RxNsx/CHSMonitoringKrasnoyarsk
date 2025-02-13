using System.Net.Mime;
using CHSMonitoring.Application.Queries.ServiceAddresses.Get;
using CHSMonitoring.Application.Queries.ServiceAddresses.GetLatestList;
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
    [HttpGet]
    [Route("[action]")]
    [ProducesResponseType<List<ServiceAddress>>(200, contentType: MediaTypeNames.Application.Json)]
    public async Task<IActionResult> GetServiceAddressAsync([FromQuery] string streetName, string houseNumber)
    {
        var resultServiceAddress = await _sender.Send(new GetServiceAddressQuery(streetName, houseNumber))
            .ConfigureAwait(false);
        if (!resultServiceAddress.IsSuccess)
        {
            return BadRequest(resultServiceAddress.Error.Text);
        }
        
        return Ok(resultServiceAddress.Value);
    }

    /// <summary>
    /// Получить информацию по списку названий улиц
    /// </summary>
    /// <param name="streetNames"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("[action]")]
    [ProducesResponseType<List<ServiceAddress>>(200, MediaTypeNames.Application.Json)]
    public async Task<IActionResult> GetServiceAddresesByStreetNamesAsync([FromQuery] List<string> streetNames)
    {
        var resultServiceAddress = await _sender.Send(new GetServiceAddressListQuery(streetNames))
            .ConfigureAwait(false);
        if (!resultServiceAddress.IsSuccess)
        {
            return BadRequest(resultServiceAddress.Error.Text);
        }
        
        return Ok(resultServiceAddress.Value);
    }
    
    /// <summary>
    /// Получение последних данных по отключениям
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("[action]")]
    [ProducesResponseType<List<ServiceAddress>>(200, MediaTypeNames.Application.Json)]
    public async Task<IActionResult> GetLatestServiceAddressAsync(CancellationToken cancellationToken)
    {
        var resultServicesAddresses = await _sender.Send(new GetLatestListServiceAddressQuery())
            .ConfigureAwait(false);
        if (resultServicesAddresses.IsSuccess)
        {
            return BadRequest(resultServicesAddresses.Error.Text);
        }

        return Ok(resultServicesAddresses.Value);
    }
}