using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using CHSMonitoring.Domain.Entities;
using CHSMonitoring.Infrastructure.Interfaces;
using CHSMonitoring.Infrastructure.Settings;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace CHSMonitoring.Infrastructure.Services;

/// <summary>
/// Интерфейс сервиса получения токена
/// </summary>
public class TokenService : ITokenService
{
    private readonly AuthSettings _authSettings;

    public TokenService(IOptions<AuthSettings> authSettings)
    {
        _authSettings = authSettings.Value;
    }

    public string GenerateToken(User user)
    {
        var claims = new List<Claim>()
        {
            new("UserName", user.UserName),
            new("UserId", user.Id.ToString()),
            new(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new("CreatedTime", $"{DateTime.UtcNow}")
        };

        var jwtToken = new JwtSecurityToken(
            issuer: _authSettings.Issuer,
            audience: _authSettings.Audience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(_authSettings.ExpirationTimeMinutes),
            signingCredentials: new SigningCredentials(AuthSettings.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256)
        );

        return new JwtSecurityTokenHandler().WriteToken(jwtToken);
    }
}