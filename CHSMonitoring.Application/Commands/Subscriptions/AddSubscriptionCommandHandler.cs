using CHSMonitoring.Infrastructure.Interfaces;
using MediatR;

namespace CHSMonitoring.Application.Commands.Subscriptions;

/// <summary>
/// Обработчик команды добавления подписки
/// </summary>
public class AddSubscriptionCommandHandler : IRequestHandler<AddSubscriptionCommand>
{
    private readonly ISubscriptionRepository _subscriptionRepository;
    private readonly IProfileRepository _profileRepository;
    private readonly IUserRepository _userRepository;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="subscriptionRepository"></param>
    /// <param name="profileRepository"></param>
    /// <param name="userRepository"></param>
    public AddSubscriptionCommandHandler(ISubscriptionRepository subscriptionRepository, IProfileRepository profileRepository, IUserRepository userRepository)
    {
        _subscriptionRepository = subscriptionRepository;
        _profileRepository = profileRepository;
        _userRepository = userRepository;
    }

    public async Task Handle(AddSubscriptionCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetUserByLoginNameAsync(request.LoginName, cancellationToken)
            .ConfigureAwait(false);
        if (user is null)
        {
            throw new ArgumentNullException(nameof(user), "some");
        }
        
        await _subscriptionRepository.AddWebApplicationSubscriptionAsync(user.Id, request.DistrictId, request.StreetId, cancellationToken);
        
    }
}