using CHSMonitoring.Application.Dtos.Login;
using MediatR;
using VplayRequestTransmitter.Shared;

namespace CHSMonitoring.Application.Commands.Login;

public record LoginUserCommand(string LoginName, string Password) : IRequest<Result<LoginUserDto>>
{
}