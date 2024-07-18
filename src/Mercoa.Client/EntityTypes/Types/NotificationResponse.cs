using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record NotificationResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The invoice ID that this notification is related to. This field is only present for notifications related to invoices.
    /// </summary>
    [JsonPropertyName("invoiceId")]
    public string? InvoiceId { get; init; }

    [JsonPropertyName("type")]
    public required NotificationType Type { get; init; }

    [JsonPropertyName("status")]
    public required NotificationStatus Status { get; init; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; init; }
}
