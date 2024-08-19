using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record InvoiceEmailWebhook
{
    [JsonPropertyName("eventType")]
    public required string EventType { get; set; }

    /// <summary>
    /// If an invoice was created from the email, this will be present.
    /// </summary>
    [JsonPropertyName("invoice")]
    public InvoiceResponse? Invoice { get; set; }

    /// <summary>
    /// If an existing invoice already exists for the email, this will be present.
    /// </summary>
    [JsonPropertyName("existingInvoiceId")]
    public string? ExistingInvoiceId { get; set; }
}
