using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class InvoiceMetricsResponse
{
    [JsonPropertyName("totalAmount")]
    public double TotalAmount { get; init; }

    [JsonPropertyName("totalCount")]
    public int TotalCount { get; init; }

    [JsonPropertyName("averageAmount")]
    public double AverageAmount { get; init; }

    [JsonPropertyName("currency")]
    public CurrencyCode Currency { get; init; }

    [JsonPropertyName("dates")]
    public Dictionary<string, InvoiceMetricsPerDateResponse>? Dates { get; init; }
}
