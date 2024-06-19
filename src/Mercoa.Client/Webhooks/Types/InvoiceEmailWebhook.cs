using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class InvoiceEmailWebhook
{
    [JsonPropertyName("eventType")]
    public string EventType { get; init; }

    /// <summary>
    /// If an invoice was created from the email, this will be present.
    /// </summary>
    [JsonPropertyName("invoice")]
    public InvoiceResponse? Invoice { get; init; }

    /// <summary>
    /// If an existing invoice already exists for the email, this will be present.
    /// </summary>
    [JsonPropertyName("existingInvoiceId")]
    public string? ExistingInvoiceId { get; init; }
}
