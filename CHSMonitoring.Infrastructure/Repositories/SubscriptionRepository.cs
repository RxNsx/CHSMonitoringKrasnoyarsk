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

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="context"></param>
    public SubscriptionRepository(MonitoringDbContext context)
    {
        _context = context;
    }

    public async Task<Subscription?> AddSubscriptionAsync(Subscription subscription, CancellationToken cancellationToken)
    {
        await _context.Subscriptions.AddAsync(subscription, cancellationToken).ConfigureAwait(false);
        await _context.SaveChangesAsync().ConfigureAwait(false);
        return subscription;
    }

    public async Task<Subscription?> UpdateSubscriptionAsync(Subscription updateSubscription, long userId, ProfileTypeEnum profileTypeEnum, CancellationToken cancellationToken)
    {
        var subscription = await GetSubscriptionAsync(userId, profileTypeEnum, cancellationToken).ConfigureAwait(false);
        if (subscription is null)
        {
            return null;
        }

        await _context.Subscriptions
            .ExecuteUpdateAsync(x => x
                .SetProperty(s => s.UpdateUserTime, updateSubscription.UpdateUserTime)
                .SetProperty(s => s.DistrictId, updateSubscription.DistrictId))
            .ConfigureAwait(false);
        return updateSubscription;
    }

    public async Task<bool> IsSubscribeExistsAsync(long userId, ProfileTypeEnum profileTypeEnum, CancellationToken cancellationToken)
    {
        return await _context.Profiles
            .AsNoTracking()
            .Include(x => x.User)
                .ThenInclude(x => x.Subscription)
            .AnyAsync(x => x.ProviderId == userId
                           && x.ProfileTypeId == profileTypeEnum.GetGuidValue(), cancellationToken)
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
}