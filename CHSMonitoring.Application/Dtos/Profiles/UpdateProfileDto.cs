namespace CHSMonitoring.Application.Dtos.Profiles;

/// <summary>
/// Модель обновления профиля
/// </summary>
public class UpdateProfileDto
{
    public string UserId { get; set; }
    public string LoginName { get; set; }
    public string Email { get; set; }
    public string? DistrictId { get; set; }
    public string? StreetId { get; set; }
}