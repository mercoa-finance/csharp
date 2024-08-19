using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CounterpartyInvoiceMetricsStatusResponse
{
    [JsonPropertyName("status")]
    public required InvoiceStatus Status { get; set; }

    [JsonPropertyName("totalCount")]
    public required int TotalCount { get; set; }

    [JsonPropertyName("totalAmount")]
    public required double TotalAmount { get; set; }
}
