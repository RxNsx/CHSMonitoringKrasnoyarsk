using CHSMonitoring.Domain.Entities;

namespace CHSMonitoring.Infrastructure.Interfaces;

/// <summary>
/// Интерфейс сервиса получения токена
/// </summary>
public interface ITokenService
{
    string GenerateToken(User user);
}