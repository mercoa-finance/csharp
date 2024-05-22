using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class NotificationResponse
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    /// <summary>
    /// The invoice ID that this notification is related to. This field is only present for notifications related to invoices.
    /// </summary>
    [JsonPropertyName("invoiceId")]
    public string? InvoiceId { get; init; }

    [JsonPropertyName("type")]
    public NotificationType Type { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }
}
