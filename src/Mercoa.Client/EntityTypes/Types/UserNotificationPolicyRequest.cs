using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record UserNotificationPolicyRequest
{
    /// <summary>
    /// Set to true if the selected notification type should be disabled for this user
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; init; }

    /// <summary>
    /// Set to true if the selected notification type should be sent as a digest. Default is false.
    /// </summary>
    [JsonPropertyName("digest")]
    public bool? Digest { get; init; }

    /// <summary>
    /// Set to true if the selected notification type should be sent immediately. Default is true.
    /// </summary>
    [JsonPropertyName("immediate")]
    public bool? Immediate { get; init; }
}
