using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record NotificationPolicyResponse
{
    /// <summary>
    /// True if the selected notification type is disabled for this entity
    /// </summary>
    [JsonPropertyName("disabled")]
    public required bool Disabled { get; init; }

    /// <summary>
    /// List of user roles that should receive notifications in addition to the default users for this notification type
    /// </summary>
    [JsonPropertyName("additionalRoles")]
    public IEnumerable<string> AdditionalRoles { get; init; } = new List<string>();

    /// <summary>
    /// True if the selected notification type is sent to the counterparty
    /// </summary>
    [JsonPropertyName("notifyCounterparty")]
    public required bool NotifyCounterparty { get; init; }

    [JsonPropertyName("type")]
    public required NotificationType Type { get; init; }
}
