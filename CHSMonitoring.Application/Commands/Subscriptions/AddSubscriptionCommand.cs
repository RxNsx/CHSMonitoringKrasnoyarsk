using MediatR;

namespace CHSMonitoring.Application.Commands.Subscriptions;

/// <summary>
/// Запрос добавления подписки
/// </summary>
/// <param name="DistrictId"></param>
/// <param name="StreetId"></param>
public record AddSubscriptionCommand(string LoginName, Guid DistrictId, Guid StreetId) : IRequest
{
    
}