using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Domain.Enums;
using CHSMonitoring.Infrastructure.Context;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CHSMonitoring.Infrastructure.Repositories;

/// <summary>
/// Репозиторий подписок
/// </summary>
public class SubscriptionRepository : ISubscriptionRepository
{
    private readonly MonitoringDbContext _context;
    private readonly IUserRepository _userRepository;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="context"></param>
    /// <param name="userRepository"></param>
    public SubscriptionRepository(MonitoringDbContext context, IUserRepository userRepository)
    {
        _context = context;
        _userRepository = userRepository;
    }

    public async Task<Subscription?> AddSubscriptionAsync(Subscription subscription, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetUserByUserIdAsync(subscription.UserId, cancellationToken).ConfigureAwait(false);
        if (subscription.UpdateUserTime != 0)
        {
            user!.LastUpdated = DateTime.UtcNow;
        }
        
        await _context.Subscriptions.AddAsync(subscription, cancellationToken).ConfigureAwait(false);
        await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

        user.SubscriptionId = subscription.Id;
        await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        
        return subscription;
    }

    public async Task<Subscription?> UpdateSubscriptionAsync(Subscription updateSubscription, long userId, ProfileTypeEnum profileTypeEnum, CancellationToken cancellationToken)
    {
        var subscription = await GetSubscriptionAsync(userId, profileTypeEnum, cancellationToken).ConfigureAwait(false);
        if (subscription is null)
        {
            return null;
        }
        
        var user = await _userRepository.GetUserByUserIdAsync(updateSubscription.UserId, cancellationToken).ConfigureAwait(false);
        user!.LastUpdated = DateTime.UtcNow;

        var updateEntity = _context.Subscriptions.Update(updateSubscription);
        await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        return updateEntity.Entity;
    }

    public async Task<bool> IsSubscribeExistsAsync(long userId, ProfileTypeEnum profileTypeEnum, CancellationToken cancellationToken)
    {
        return await _context.Profiles
            .AsNoTracking()
            .Include(x => x.User)
                .ThenInclude(x => x.Subscription)
            .AnyAsync(x => x.ProviderId == userId 
                           && x.ProfileTypeId == profileTypeEnum.GetGuidValue()
                           && x.User.Subscription != null
                , cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Subscription?> GetSubscriptionAsync(long userId, ProfileTypeEnum profileTypeEnum, CancellationToken cancellationToken)
    {
        return await _context.Profiles
            .Include(x => x.User)
                .ThenInclude(x => x.Subscription)
            .Where(x => x.ProviderId == userId && x.ProfileTypeId == profileTypeEnum.GetGuidValue())
            .Select(x => x.User.Subscription)
            .FirstOrDefaultAsync(cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<List<User>> GetNotifyUsersAsync(CancellationToken cancellationToken)
    {
        var currentDate = DateTime.UtcNow;
        var subscriptions =  await _context.Subscriptions
            .Include(x => x.User)
                .ThenInclude(x => x.Profiles)
            .Where(x => x.User.LastUpdated != null && x.UpdateUserTime != 0)
            .Select(x => new
            {
                Subscription = x,
                User = x.User
            })
            .ToListAsync(cancellationToken)
            .ConfigureAwait(false);

        return subscriptions
            .Where(x => currentDate - x.User.LastUpdated >= TimeSpan.FromMinutes(x.Subscription.UpdateUserTime))
            .Select(x => x.User)
            .ToList();
    }
}