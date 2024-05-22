using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class InvoiceMetricsPerDateResponse
{
    [JsonPropertyName("date")]
    public DateTime Date { get; init; }

    [JsonPropertyName("totalAmount")]
    public double TotalAmount { get; init; }

    [JsonPropertyName("totalCount")]
    public int TotalCount { get; init; }

    [JsonPropertyName("averageAmount")]
    public double AverageAmount { get; init; }

    [JsonPropertyName("currency")]
    public CurrencyCode Currency { get; init; }
}
