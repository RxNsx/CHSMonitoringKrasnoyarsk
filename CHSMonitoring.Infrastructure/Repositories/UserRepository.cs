using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Context;
using CHSMonitoring.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CHSMonitoring.Infrastructure.Repositories;

/// <summary>
/// Репозиторий пользователей
/// </summary>
public class UserRepository : IUserRepository
{
    private readonly MonitoringDbContext _context;
    private readonly IProfileRepository _profileRepository;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="context"></param>
    /// <param name="profileRepository"></param>
    public UserRepository(MonitoringDbContext context, IProfileRepository profileRepository)
    {
        _context = context;
        _profileRepository = profileRepository;
    }

    public async Task<User?> GetUserByLoginNameAsync(string loginName, CancellationToken cancellationToken)
    {
        return await _context.Users
            .Include(x => x.Profiles)
            .FirstOrDefaultAsync(x => x.Profiles.Any(t => t.LoginName.Equals(loginName)));
    }

    public async Task<User?> GetUserByUserIdAsync(Guid userId, CancellationToken cancellationToken)
    {
        return await _context.Users.SingleOrDefaultAsync(x => x.Id == userId, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<User?> GetUserByUserEmailAddressAsync(string emailAddress, CancellationToken cancellationToken)
    {
        return await _context.Users.SingleOrDefaultAsync(x => x.EmailAddress == emailAddress, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<User> CreateWebApplicationUserAsync(string userName, string loginName, string hashPassword, string emailAddress, CancellationToken cancellationToken)
    {
        User user = null;
        
        using var transaction = await _context.Database.BeginTransactionAsync(cancellationToken).ConfigureAwait(false);

        try
        {
            user = new User()
            {
                UserName = userName,
                EmailAddress = emailAddress
            };
            await _context.Users.AddAsync(user).ConfigureAwait(false);
            await _context.SaveChangesAsync();
            
            await _profileRepository.CreateWebProfileAsync(user.Id, loginName, hashPassword, cancellationToken)
                .ConfigureAwait(false);
            await transaction.CommitAsync(cancellationToken).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync(cancellationToken).ConfigureAwait(false);
        }

        return user;
    }

    public async Task<User> CreateTelegramUserAsync(long chatId, string userName, string telegramName, string emailAddress, CancellationToken cancellationToken)
    {
        User user = null;
        
        using var transaction = await _context.Database.BeginTransactionAsync(cancellationToken).ConfigureAwait(false);

        try
        {
            user = new User()
            {
                UserName = userName,
                EmailAddress = emailAddress
            };
            await _context.Users.AddAsync(user).ConfigureAwait(false);
            await _context.SaveChangesAsync();
            
            await _profileRepository.CreateTelegramProfileAsync(user.Id, chatId, telegramName, cancellationToken)
                .ConfigureAwait(false);
            await transaction.CommitAsync(cancellationToken).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync(cancellationToken).ConfigureAwait(false);
        }

        return user;
    }

    public async Task<bool> IsUserExists(string emailAddress, CancellationToken cancellationToken)
    {
        return await _context.Users
            .AnyAsync(x => x.EmailAddress.Equals(emailAddress))
            .ConfigureAwait(false);
    }
}