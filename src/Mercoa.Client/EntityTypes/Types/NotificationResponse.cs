using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record NotificationResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The invoice ID that this notification is related to. This field is only present for notifications related to invoices.
    /// </summary>
    [JsonPropertyName("invoiceId")]
    public string? InvoiceId { get; set; }

    [JsonPropertyName("type")]
    public required NotificationType Type { get; set; }

    [JsonPropertyName("status")]
    public required NotificationStatus Status { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }
}
