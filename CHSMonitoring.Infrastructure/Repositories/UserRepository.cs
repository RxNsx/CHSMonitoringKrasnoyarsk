using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Context;
using CHSMonitoring.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CHSMonitoring.Infrastructure.Repositories;

/// <summary>
/// Репозиторий пользователей
/// </summary>
public class UserRepository : IUserRepository
{
    private readonly MonitoringDbContext _context;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="context"></param>
    public UserRepository(MonitoringDbContext context)
    {
        _context = context;
    }

    public async Task<User?> GetUserByLoginNameAsync(string loginName, CancellationToken cancellationToken)
    {
        return await _context.Users.SingleOrDefaultAsync(x => x.LoginName == loginName)
            .ConfigureAwait(false);
    }

    public async Task<User?> GetUserByUserIdAsync(Guid userId, CancellationToken cancellationToken)
    {
        return await _context.Users.SingleOrDefaultAsync(x => x.Id == userId)
            .ConfigureAwait(false);
    }

    public async Task<User> CreateUserAsync(string userName, string loginName, string hashPassword, string email, CancellationToken cancellationToken)
    {
        var user = new User()
        {
            UserName = userName,
            LoginName = loginName,
            Password = hashPassword,
            EmailAddress = email
        };
        
        await _context.Users.AddAsync(user).ConfigureAwait(false);
        await _context.SaveChangesAsync();
        return user;
    }
    
    public async Task<bool> IsUserExists(string loginName, CancellationToken cancellationToken)
    {
        return await _context.Users.AnyAsync(x => x.LoginName == loginName)
            .ConfigureAwait(false);
    }
}