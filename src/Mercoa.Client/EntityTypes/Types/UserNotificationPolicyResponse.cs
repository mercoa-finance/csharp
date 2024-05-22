using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class UserNotificationPolicyResponse
{
    /// <summary>
    /// True if the selected notification type is disabled for this user
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool Disabled { get; init; }

    /// <summary>
    /// True if the selected notification type is sent as a digest.
    /// </summary>
    [JsonPropertyName("digest")]
    public bool Digest { get; init; }

    /// <summary>
    /// True if the selected notification type is sent immediately.
    /// </summary>
    [JsonPropertyName("immediate")]
    public bool Immediate { get; init; }

    [JsonPropertyName("type")]
    public NotificationType Type { get; init; }
}
