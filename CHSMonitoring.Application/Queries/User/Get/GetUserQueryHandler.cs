using CHSMonitoring.Application.Dtos.User;
using CHSMonitoring.Application.Errors.GetUserErrors;
using CHSMonitoring.Infrastructure.Interfaces;
using MediatR;
using Shared;

namespace CHSMonitoring.Application.Queries.User.Get;

public class GetUserQueryHandler : IRequestHandler<GetUserQuery, Result<GetUserDto>>
{
    private readonly IProfileRepository _profileRepository;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="userRepository"></param>
    /// <param name="profileRepository"></param>
    public GetUserQueryHandler(IProfileRepository profileRepository)
    {
        _profileRepository = profileRepository;
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
        
        return Result.Success<GetUserDto>(new GetUserDto() { UserName = webProfile.User.UserName, Email = webProfile.User.EmailAddress });
    }
}