using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Domain.Enums;
using CHSMonitoring.Infrastructure.Context;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CHSMonitoring.Infrastructure.Repositories;

/// <summary>
/// Репозиторий профилей авторизации для пользователя
/// </summary>
public class ProfileRepository : IProfileRepository
{
    private readonly MonitoringDbContext _context;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="context"></param>
    public ProfileRepository(MonitoringDbContext context)
    {
        _context = context;
    }

    public async Task<Profile> CreateTelegramProfileAsync(Guid userId, long chatId, string telegramName, CancellationToken cancellationToken)
    {
        var profile = new Profile()
        {
            ProfileTypeId = ProfileTypeEnum.Telegram.GetGuidValue(),
            ProviderId = chatId,
            LoginName = telegramName,
            UserId = userId
        };
        
        await _context.Profiles.AddAsync(profile, cancellationToken).ConfigureAwait(false);
        await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

        return profile;
    }

    public async Task<Profile> CreateWebProfileAsync(Guid userId, string loginName, string password, CancellationToken cancellationToken)
    {
        var profile = new Profile()
        {
            ProfileTypeId = ProfileTypeEnum.WebApplication.GetGuidValue(),
            LoginName = loginName,
            Password = password,
            UserId = userId
        };

        await _context.Profiles.AddAsync(profile, cancellationToken).ConfigureAwait(false);
        await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

        return profile;
    }

    public async Task<bool> IsExistProfileAsync(Guid userId, ProfileTypeEnum profileTypeEnum)
    {
        return await _context.Users
            .Include(x => x.Profiles)
            .AnyAsync(x => x.Profiles.Any(t => t.Id == profileTypeEnum.GetGuidValue()))
            .ConfigureAwait(false);
    }

    public async Task<bool> IsTelegramProfileAsync(long chatId)
    {
        return await _context.Users
            .Include(x => x.Profiles)
            .AnyAsync(x => x.Profiles.Any(t => t.ProviderId == chatId))
            .ConfigureAwait(false);
    }

    public async Task<Profile?> GetTelegramProfileAsync(Guid userId, CancellationToken cancellationToken)
    {
        return await _context.Profiles
            .Include(x => x.User)
            .FirstOrDefaultAsync(x => x.UserId == userId && x.ProfileTypeId == ProfileTypeEnum.Telegram.GetGuidValue(), cancellationToken)
            .ConfigureAwait(false);
    }
}