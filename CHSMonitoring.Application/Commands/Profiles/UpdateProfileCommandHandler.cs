using CHSMonitoring.Application.Dtos.Profiles;
using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Interfaces;
using MediatR;

namespace CHSMonitoring.Application.Commands.Profiles;

/// <summary>
/// Обработчик обновления профиля пользователя
/// </summary>
public class UpdateProfileCommandHandler : IRequestHandler<UpdateProfileCommand, UpdateUserProfileResponse>
{
    private readonly IProfileRepository _profileRepository;
    private readonly IUserRepository _userRepository;
    private readonly ISubscriptionRepository _subscriptionRepository;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="profileRepository"></param>
    /// <param name="userRepository"></param>
    /// <param name="subscriptionRepository"></param>
    public UpdateProfileCommandHandler(IProfileRepository profileRepository, IUserRepository userRepository, ISubscriptionRepository subscriptionRepository)
    {
        _profileRepository = profileRepository;
        _userRepository = userRepository;
        _subscriptionRepository = subscriptionRepository;
    }
    
    public async Task<UpdateUserProfileResponse> Handle(UpdateProfileCommand request, CancellationToken cancellationToken)
    {
        var profile = await _profileRepository.GetWebApplicationProfileByUserIdAsync(request.UserId, cancellationToken)
            .ConfigureAwait(false);
        if (profile is null)
        {
            //TODO: Fix profile error
            throw new ArgumentNullException(nameof(profile), "some");
        }
        
        var user = await _userRepository.GetUserByUserIdAsync(request.UserId, cancellationToken)
            .ConfigureAwait(false);
        if (user is null)
        {
            throw new ArgumentNullException(nameof(user), "some");
        }
        
        if (!profile.LoginName.Equals(request.LoginName, StringComparison.InvariantCultureIgnoreCase))
        {
            await _profileRepository.UpdateWebApplicationProfileByUserIdAsync(user.Id, request.LoginName, cancellationToken)
                .ConfigureAwait(false);
        }

        if (request.DistrictId.HasValue || request.StreetId.HasValue)
        {
            var subscription = await _subscriptionRepository.GetWebApplicationSubscriptionAsync(user.Id, cancellationToken)
                .ConfigureAwait(false);
            if (subscription is null)
            {
                await _subscriptionRepository.AddWebApplicationSubscriptionAsync(user.Id, request.DistrictId, request.StreetId, cancellationToken)
                    .ConfigureAwait(false);
            }
            else
            {
                await _subscriptionRepository.UpdateWebApplicationSubscriptionAsync(user.Id, request.DistrictId, request.StreetId, cancellationToken)
                    .ConfigureAwait(false);
            }
        }
        


        return new UpdateUserProfileResponse() { Status = "200" };
    }
}