using CHSMonitoring.Application.Dtos.User;
using MediatR;
using Shared;

namespace CHSMonitoring.Application.Queries.User.Get;

public record GetUserQuery(string LoginName) : IRequest<Result<GetUserDto>>
{
    
}