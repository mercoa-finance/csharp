using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class NotificationPolicyResponse
{
    /// <summary>
    /// True if the selected notification type is disabled for this entity
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool Disabled { get; init; }

    /// <summary>
    /// List of user roles that should receive notifications in addition to the default users for this notification type
    /// </summary>
    [JsonPropertyName("additionalRoles")]
    public List<string> AdditionalRoles { get; init; }

    [JsonPropertyName("type")]
    public NotificationType Type { get; init; }
}
