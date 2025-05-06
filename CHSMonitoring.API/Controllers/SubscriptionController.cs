using CHSMonitoring.Application.Commands.Subscriptions;
using CHSMonitoring.Application.Dtos.Subscriptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CHSMonitoring.API.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class SubscriptionsController : ControllerBase
{
    private readonly IMediator _mediator;
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="mediator"></param>
    public SubscriptionsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> AddSubscribeAsync([FromBody] SubscribeAddItemDto subscribeAddItemDto, CancellationToken cancellationToken)
    {
        await _mediator.Send(new AddSubscriptionCommand(subscribeAddItemDto.LoginName, subscribeAddItemDto.DistrictId, subscribeAddItemDto.StreetId),  cancellationToken);
        return Ok();
    }
}