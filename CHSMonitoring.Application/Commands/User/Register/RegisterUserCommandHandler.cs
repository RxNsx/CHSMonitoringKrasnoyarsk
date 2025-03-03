using CHSMonitoring.Application.Dtos.User;
using CHSMonitoring.Application.Errors.RegisterUserErrors;
using CHSMonitoring.Domain.Enums;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;
using MediatR;
using Shared;

namespace CHSMonitoring.Application.Commands.User.Register;

public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, Result<RegisterUserDto>>
{
    private readonly IUserRepository _userRepository;
    private readonly IHashPasswordService _hashPasswordService;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="userRepository"></param>
    /// <param name="hashPasswordService"></param>
    public RegisterUserCommandHandler(IUserRepository userRepository, IHashPasswordService hashPasswordService)
    {
        _userRepository = userRepository;
        _hashPasswordService = hashPasswordService;
    }
    
    public async Task<Result<RegisterUserDto>> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        var isUserExists = await _userRepository.IsUserExists(request.Email, cancellationToken)
            .ConfigureAwait(false);
        if (isUserExists)
        {
            return Result.Failure<RegisterUserDto>(RegisterUserError.UserAlreadyExists());
        }
        
        var hashPassword = _hashPasswordService.HashPassword(request.Password);
        var createdUser = await _userRepository.CreateWebApplicationUserAsync(request.UserName, request.LoginName, hashPassword, request.Email, cancellationToken).ConfigureAwait(false);
        
        return Result.Success(new RegisterUserDto()
        {
            LoginName = createdUser.Profiles.FirstOrDefault(x => x.ProfileTypeId == ProfileTypeEnum.WebApplication.GetGuidValue())!.LoginName,
            UserName = createdUser.UserName,
            Email = createdUser.EmailAddress
        });
    }
}