using CHSMonitoring.Application.Dtos.Profiles;
using MediatR;

namespace CHSMonitoring.Application.Commands.Profiles;

/// <summary>
/// Команда обновления профиля пользователя
/// </summary>
/// <param name="UserName"></param>
/// <param name="UserEmail"></param>
/// <param name="DistrictId"></param>
/// <param name="StreetId"></param>
public record UpdateProfileCommand(Guid UserId, string LoginName, string UserEmail, Guid? DistrictId, Guid? StreetId) : IRequest<UpdateUserProfileResponse>
{
    
}