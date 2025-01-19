namespace CHSMonitoring.Domain.Entities;

/// <summary>
/// Права пользователей
/// </summary>
public class Permission : Entity
{
    /// <summary>
    /// Название разрешения
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Аттрибуты разрешений
    /// </summary>
    public string Attributes { get; set; }
}