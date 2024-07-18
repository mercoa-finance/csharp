using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record InvoiceMetricsResponse
{
    [JsonPropertyName("totalAmount")]
    public required double TotalAmount { get; init; }

    [JsonPropertyName("totalCount")]
    public required int TotalCount { get; init; }

    [JsonPropertyName("averageAmount")]
    public required double AverageAmount { get; init; }

    [JsonPropertyName("currency")]
    public required CurrencyCode Currency { get; init; }

    [JsonPropertyName("dates")]
    public Dictionary<string, InvoiceMetricsPerDateResponse>? Dates { get; init; }
}
