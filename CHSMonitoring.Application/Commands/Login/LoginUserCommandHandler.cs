using CHSMonitoring.Application.Dtos.Login;
using CHSMonitoring.Application.Errors.LoginUserErrors;
using CHSMonitoring.Domain.Enums;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;
using MediatR;
using Shared;

namespace CHSMonitoring.Application.Commands.Login;

public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, Result<LoginUserDto>>
{
    private readonly IUserRepository _userRepository;
    private readonly IHashPasswordService _hashPasswordService;
    private readonly ITokenService _tokenService;
    private readonly IProfileRepository _profileRepository;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="userRepository"></param>
    /// <param name="hashPasswordService"></param>
    /// <param name="tokenService"></param>
    /// <param name="profileRepository"></param>
    public LoginUserCommandHandler(IUserRepository userRepository, IHashPasswordService hashPasswordService, ITokenService tokenService, IProfileRepository profileRepository)
    {
        _userRepository = userRepository;
        _hashPasswordService = hashPasswordService;
        _tokenService = tokenService;
        _profileRepository = profileRepository;
    }

    public async Task<Result<LoginUserDto>> Handle(LoginUserCommand request, CancellationToken cancellationToken)
    {
        var webProfile = await _profileRepository.GetWebApplicationProfileByLoginNameAsync(request.LoginName, cancellationToken);
        if (webProfile is null)
        {
            return Result.Failure<LoginUserDto>(LoginUserError.NotFound());
        }
        
        var isPasswordCorrect = _hashPasswordService.VerifyPassword(request.Password, webProfile!.Password);
        if (!isPasswordCorrect)
        {
            return Result.Failure<LoginUserDto>(LoginUserError.IncorrectPassword());
        }
        
        var token = _tokenService.GenerateToken(webProfile.User);
        var userDto = new LoginUserDto()
        {
            LoginName = webProfile.LoginName,
            TokenData = token
        };

        return Result.Success(userDto);
    }
}