using CHSMonitoring.Application.Dtos.User;
using CHSMonitoring.Application.Errors.GetUserErrors;
using CHSMonitoring.Infrastructure.Interfaces;
using MediatR;
using Shared;

namespace CHSMonitoring.Application.Queries.User.Get;

public class GetUserQueryHandler : IRequestHandler<GetUserQuery, Result<GetUserDto>>
{
    private readonly IProfileRepository _profileRepository;
    private readonly ISubscriptionRepository _subscriptionRepository;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="profileRepository"></param>
    /// <param name="subscriptionRepository"></param>
    public GetUserQueryHandler(IProfileRepository profileRepository, ISubscriptionRepository subscriptionRepository)
    {
        _profileRepository = profileRepository;
        _subscriptionRepository = subscriptionRepository;
    }

    public async Task<Result<GetUserDto>> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        var webProfile = await _profileRepository
            .GetWebApplicationProfileByLoginNameAsync(request.LoginName, cancellationToken)
            .ConfigureAwait(false);
        if (webProfile is null)
        {
            return Result.Failure<GetUserDto>(GetUserError.NotFoundWebProfile);
        }
        
        var userDto = new GetUserDto()
        {
            UserName = webProfile.User.UserName,
            Email = webProfile.User.EmailAddress
        };
        
        var webApplicationSubscriptionInfo = await _subscriptionRepository.GetWebApplicationSubscriptionasync(webProfile.UserId, cancellationToken)
            .ConfigureAwait(false);
        if (webApplicationSubscriptionInfo is null)
        {
            userDto.DistrictId = string.Empty;
            userDto.DistrictName = string.Empty;
            userDto.StreetId = string.Empty;
            userDto.StreetName = string.Empty;
        }
        
        return Result.Success(userDto);
    }
}