using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record InvoiceTiming
{
    [JsonPropertyName("invoiceId")]
    public required string InvoiceId { get; set; }
}
