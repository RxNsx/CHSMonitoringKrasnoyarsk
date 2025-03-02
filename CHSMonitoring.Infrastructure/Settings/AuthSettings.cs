using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace CHSMonitoring.Infrastructure.Settings;

/// <summary>
/// Настройки для авторизации
/// </summary>
public class AuthSettings
{
    private readonly IConfiguration _configuration;

    public AuthSettings()
    {
        
    }
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="configuration"></param>
    public AuthSettings(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    //TODO: _configuration["JwtTokenSecurityKey"]
    /// <summary>
    /// Секретный ключ
    /// </summary>
    private const string SecretKey = "74D677AB-A09E-44C3-9F77-867677CFB140-34E7C5BC-98B2-4EBD-8E7A-2E904B42FA89";

    /// <summary>
    /// Издатель токена
    /// </summary>
    public string Issuer { get; set; }
    /// <summary>
    /// Потребитель токена
    /// </summary>
    public string Audience { get; set; }
    /// <summary>
    /// Время действия токена
    /// </summary>
    public int ExpirationTimeMinutes { get; set; }

    /// <summary>
    /// Создание симметричного ключа
    /// </summary>
    /// <returns></returns>
    public static SymmetricSecurityKey GetSymmetricSecurityKey()
    {
        return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
    }
}