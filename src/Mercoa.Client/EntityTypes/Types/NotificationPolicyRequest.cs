using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record NotificationPolicyRequest
{
    /// <summary>
    /// Set to true if the selected notification type should be disabled for this entity
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; init; }

    /// <summary>
    /// List of user roles that should receive notifications in addition to the default users for this notification type
    /// </summary>
    [JsonPropertyName("additionalRoles")]
    public IEnumerable<string>? AdditionalRoles { get; init; }

    /// <summary>
    /// Set to true if the selected notification type should be sent to the counterparty if this is a payable invoice.
    /// </summary>
    [JsonPropertyName("notifyPayeeCounterparty")]
    public bool? NotifyPayeeCounterparty { get; init; }

    /// <summary>
    /// Set to true if the selected notification type should be sent to the counterparty if this is a receivable invoice.
    /// </summary>
    [JsonPropertyName("notifyPayorCounterparty")]
    public bool? NotifyPayorCounterparty { get; init; }
}
