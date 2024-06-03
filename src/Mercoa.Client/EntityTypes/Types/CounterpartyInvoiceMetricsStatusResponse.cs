using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class CounterpartyInvoiceMetricsStatusResponse
{
    [JsonPropertyName("status")]
    public InvoiceStatus Status { get; init; }

    [JsonPropertyName("totalCount")]
    public int TotalCount { get; init; }

    [JsonPropertyName("totalAmount")]
    public double TotalAmount { get; init; }
}
