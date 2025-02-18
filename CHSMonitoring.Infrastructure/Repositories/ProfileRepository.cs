using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Domain.Enums;
using CHSMonitoring.Infrastructure.Context;
using CHSMonitoring.Infrastructure.Extensions;
using CHSMonitoring.Infrastructure.Interfaces;

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


    public Task CreateTelegramProfileAsync(Guid userId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
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
}