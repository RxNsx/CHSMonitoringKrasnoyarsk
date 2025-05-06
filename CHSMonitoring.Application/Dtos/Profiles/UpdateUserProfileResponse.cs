using System.Text.Json.Serialization;

namespace CHSMonitoring.Application.Dtos.Profiles;

public class UpdateUserProfileResponse
{
    [JsonPropertyName("status")]
    public string Status { get; set; }
}