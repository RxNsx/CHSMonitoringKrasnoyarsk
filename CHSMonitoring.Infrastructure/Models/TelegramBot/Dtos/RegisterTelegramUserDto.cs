using System.ComponentModel.DataAnnotations;

namespace CHSMonitoring.Infrastructure.Models.TelegramBot.Dtos;

/// <summary>
/// Модель для регистрации нового пользователя Telegram
/// </summary>
public class RegisterTelegramUserDto
{
    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Почтовый адрес
    /// </summary>
    [EmailAddress]
    public string  EmailAddress { get; set; }
}