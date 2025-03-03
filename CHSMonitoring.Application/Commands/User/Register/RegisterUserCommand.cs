using CHSMonitoring.Application.Dtos.User;
using MediatR;
using Shared;

namespace CHSMonitoring.Application.Commands.User.Register;

public record RegisterUserCommand(string UserName, string LoginName, string Password, string Email) : IRequest<Result<RegisterUserDto>>
{
    
}