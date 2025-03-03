using CHSMonitoring.Application.Dtos;
using CHSMonitoring.Application.Dtos.Login;
using CHSMonitoring.Application.Errors.LoginUserErrors;
using CHSMonitoring.Domain.Enums;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;
using MediatR;
using VplayRequestTransmitter.Shared;

namespace CHSMonitoring.Application.Commands.Login;

public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, Result<LoginUserDto>>
{
    private readonly IUserRepository _userRepository;
    private readonly IHashPasswordService _hashPasswordService;
    private readonly ITokenService _tokenService;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="userRepository"></param>
    /// <param name="hashPasswordService"></param>
    /// <param name="tokenService"></param>
    public LoginUserCommandHandler(IUserRepository userRepository, IHashPasswordService hashPasswordService, ITokenService tokenService)
    {
        _userRepository = userRepository;
        _hashPasswordService = hashPasswordService;
        _tokenService = tokenService;
    }

    public async Task<Result<LoginUserDto>> Handle(LoginUserCommand request, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetUserByLoginNameAsync(request.LoginName, cancellationToken)
            .ConfigureAwait(false);
        if (!users.Any())
        {
            return Result.Failure<LoginUserDto>(LoginUserError.NotFound());
        }

        var userWebProfile = users
            .SelectMany(x => x.Profiles)
            .FirstOrDefault(x => x.ProfileTypeId == ProfileTypeEnum.WebApplication.GetGuidValue());
        var isPasswordCorrect = _hashPasswordService.VerifyPassword(request.Password, userWebProfile!.Password);
        if (!isPasswordCorrect)
        {
            return Result.Failure<LoginUserDto>(LoginUserError.IncorrectPassword());
        }
        
        var token = _tokenService.GenerateToken(userWebProfile.User);
        var userDto = new LoginUserDto()
        {
            LoginName = userWebProfile.LoginName,
            TokenData = token
        };

        return Result.Success(userDto);
    }
}