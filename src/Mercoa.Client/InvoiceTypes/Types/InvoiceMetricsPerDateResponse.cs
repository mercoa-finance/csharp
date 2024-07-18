using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record InvoiceMetricsPerDateResponse
{
    [JsonPropertyName("date")]
    public required DateTime Date { get; init; }

    [JsonPropertyName("totalAmount")]
    public required double TotalAmount { get; init; }

    [JsonPropertyName("totalCount")]
    public required int TotalCount { get; init; }

    [JsonPropertyName("averageAmount")]
    public required double AverageAmount { get; init; }

    [JsonPropertyName("currency")]
    public required CurrencyCode Currency { get; init; }
}
