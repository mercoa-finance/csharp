using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record UserNotificationPolicyResponse
{
    /// <summary>
    /// True if the selected notification type is disabled for this user
    /// </summary>
    [JsonPropertyName("disabled")]
    public required bool Disabled { get; init; }

    /// <summary>
    /// True if the selected notification type is sent as a digest.
    /// </summary>
    [JsonPropertyName("digest")]
    public required bool Digest { get; init; }

    /// <summary>
    /// True if the selected notification type is sent immediately.
    /// </summary>
    [JsonPropertyName("immediate")]
    public required bool Immediate { get; init; }

    [JsonPropertyName("type")]
    public required NotificationType Type { get; init; }
}
