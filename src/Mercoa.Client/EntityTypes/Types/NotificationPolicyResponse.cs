using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record NotificationPolicyResponse
{
    /// <summary>
    /// True if the selected notification type is disabled for this entity
    /// </summary>
    [JsonPropertyName("disabled")]
    public required bool Disabled { get; set; }

    /// <summary>
    /// List of user roles that should receive notifications in addition to the default users for this notification type
    /// </summary>
    [JsonPropertyName("additionalRoles")]
    public IEnumerable<string> AdditionalRoles { get; set; } = new List<string>();

    /// <summary>
    /// List of user IDs that should receive notifications in addition to the default users for this notification type
    /// </summary>
    [JsonPropertyName("additionalUsers")]
    public IEnumerable<string> AdditionalUsers { get; set; } = new List<string>();

    /// <summary>
    /// True if the selected notification type should be sent to the counterparty if this is a payable invoice.
    /// </summary>
    [JsonPropertyName("notifyPayeeCounterparty")]
    public required bool NotifyPayeeCounterparty { get; set; }

    /// <summary>
    /// True if the selected notification type should be sent to the counterparty if this is a receivable invoice.
    /// </summary>
    [JsonPropertyName("notifyPayorCounterparty")]
    public required bool NotifyPayorCounterparty { get; set; }

    [JsonPropertyName("type")]
    public required NotificationType Type { get; set; }
}
