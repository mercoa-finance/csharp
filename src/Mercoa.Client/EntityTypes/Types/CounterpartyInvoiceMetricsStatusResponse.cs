using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record CounterpartyInvoiceMetricsStatusResponse
{
    [JsonPropertyName("status")]
    public required InvoiceStatus Status { get; init; }

    [JsonPropertyName("totalCount")]
    public required int TotalCount { get; init; }

    [JsonPropertyName("totalAmount")]
    public required double TotalAmount { get; init; }
}
