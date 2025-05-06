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
    private readonly IProfileRepository _profileRepository;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="context"></param>
    /// <param name="userRepository"></param>
    /// <param name="profileRepository"></param>
    public SubscriptionRepository(MonitoringDbContext context, IUserRepository userRepository, IProfileRepository profileRepository)
    {
        _context = context;
        _userRepository = userRepository;
        _profileRepository = profileRepository;
    }

    /// <summary>
    /// Добавление подписки для пользователя по профилю с определенным временным обновлением
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="profileId"></param>
    /// <param name="districtId"></param>
    /// <param name="updateUserTime"></param>
    /// <param name="profileTypeEnum"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Subscription?> AddSubscriptionAsync(Guid userId, long profileId, Guid districtId, int updateUserTime, ProfileTypeEnum profileTypeEnum, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetUserByUserIdAsync(userId, cancellationToken).ConfigureAwait(false);
        if (updateUserTime != 0)
        {
            user!.LastUpdated = DateTime.UtcNow;
        }

        var profile = await _profileRepository.GetTelegramProfileAsync(userId, cancellationToken)
            .ConfigureAwait(false);
        var subscription = new Subscription()
        {
            ProfileId = profile!.Id,
            DistrictId = districtId,
            UpdateUserTime = updateUserTime
        };
        await _context.Subscriptions.AddAsync(subscription, cancellationToken).ConfigureAwait(false);
        await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        return subscription;
    }

    public async Task UpdateTelegramSubscriptionAsync(Guid userId, long profileId, Subscription updateSubscription, ProfileTypeEnum profileTypeEnum, CancellationToken cancellationToken)
    {
        var subscription = await GetTelegramSubscriptionAsync(profileId, cancellationToken).ConfigureAwait(false);
        if (subscription is null)
        {
            Console.WriteLine($"Error");
            return;
        }

        var user = await _userRepository.GetUserByUserIdAsync(userId, cancellationToken).ConfigureAwait(false);
        user!.LastUpdated = DateTime.UtcNow;
        await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

        await _context.Subscriptions
            .Where(x => x.Id == subscription.Id)
            .ExecuteUpdateAsync(x => x
                .SetProperty(t => t.UpdateUserTime, updateSubscription.UpdateUserTime)
                .SetProperty(t => t.DistrictId, updateSubscription.DistrictId))
            .ConfigureAwait(false);
    }

    public async Task<bool> IsSubscribeExistsAsync(long profileId, ProfileTypeEnum profileTypeEnum, CancellationToken cancellationToken)
    {
        return await _context.Profiles
            .AsNoTracking()
            .Include(x => x.Subscription)
            .Include(x => x.User)
            .AnyAsync(x => x.ProviderId == profileId && x.ProfileTypeId == profileTypeEnum.GetGuidValue() && x.Subscription != null)
            .ConfigureAwait(false);
    }

    public async Task<Subscription?> GetWebApplicationSubscriptionasync(Guid userId, CancellationToken cancellationToken)
    {
        return await _context.Profiles
            .Include(x => x.Subscription)
            .Include(x => x.User)
            .Where(x => x.UserId == userId && x.ProfileTypeId == ProfileTypeEnum.WebApplication.GetGuidValue())
            .Select(x => x.Subscription)
            .FirstOrDefaultAsync(cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<Subscription?> GetTelegramSubscriptionAsync(long telegramProfileId, CancellationToken cancellationToken)
    {
        return await _context.Profiles
            .Include(x => x.Subscription)
            .Include(x => x.User)
            .Where(x => x.ProviderId == telegramProfileId && x.ProfileTypeId == ProfileTypeEnum.Telegram.GetGuidValue())
            .Select(x => x.Subscription)
            .FirstOrDefaultAsync(cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<List<User>> GetNotifyUsersAsync(CancellationToken cancellationToken)
    {
        var subscriptionsCount = await _context.Subscriptions.CountAsync().ConfigureAwait(false);
        if (subscriptionsCount <= 0)
        {
            return new List<User>();
        }
        
        var currentDate = DateTime.UtcNow;
        var subscriptions =  await _context.Subscriptions
            .Include(x => x.Profile)
                .ThenInclude(x => x.User)
            .Where(x => x.Profile.User.LastUpdated != null && x.UpdateUserTime != 0)
            .Select(x => new
            {
                Subscription = x,
                User = x.Profile.User,
                Time = currentDate - x.Profile.User.LastUpdated
            })
            .ToListAsync(cancellationToken)
            .ConfigureAwait(false);
        
        return subscriptions
            .Where(x => x.Time >= TimeSpan.FromMinutes(x.Subscription.UpdateUserTime))
            .Select(x => x.User)
            .ToList();
    }
}