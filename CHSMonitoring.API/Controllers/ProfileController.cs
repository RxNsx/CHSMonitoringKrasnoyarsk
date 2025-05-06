using CHSMonitoring.Application.Commands.Profiles;
using CHSMonitoring.Application.Dtos.Profiles;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CHSMonitoring.API.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class ProfilesController : ControllerBase
{
    private readonly IMediator _mediator;
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="mediator"></param>
    public ProfilesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> UpdateProfileAsync([FromBody] UpdateProfileDto updateProfileDto, CancellationToken cancellationToken)
    {
        var userId = Guid.Parse(updateProfileDto.UserId);
        Guid? districtId = string.IsNullOrEmpty(updateProfileDto.DistrictId) 
            ? null 
            : Guid.Parse(updateProfileDto.DistrictId);
        Guid? streetId = string.IsNullOrEmpty(updateProfileDto.StreetId) 
            ? null 
            : Guid.Parse(updateProfileDto.StreetId);
        
        
        var result = await _mediator.Send(new UpdateProfileCommand(userId, updateProfileDto.LoginName, updateProfileDto.Email, districtId, streetId), cancellationToken)
                .ConfigureAwait(false);
        return Ok(result);
    }
}