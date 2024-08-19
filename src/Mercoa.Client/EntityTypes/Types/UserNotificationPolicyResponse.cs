using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record UserNotificationPolicyResponse
{
    /// <summary>
    /// True if the selected notification type is disabled for this user
    /// </summary>
    [JsonPropertyName("disabled")]
    public required bool Disabled { get; set; }

    /// <summary>
    /// True if the selected notification type is sent as a digest.
    /// </summary>
    [JsonPropertyName("digest")]
    public required bool Digest { get; set; }

    /// <summary>
    /// True if the selected notification type is sent immediately.
    /// </summary>
    [JsonPropertyName("immediate")]
    public required bool Immediate { get; set; }

    [JsonPropertyName("type")]
    public required NotificationType Type { get; set; }
}
