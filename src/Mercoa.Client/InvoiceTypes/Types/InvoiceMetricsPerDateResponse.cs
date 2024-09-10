using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record InvoiceMetricsPerDateResponse
{
    /// <summary>
    /// If groupBy is provided, this will be the group by value.
    /// </summary>
    [JsonPropertyName("group")]
    public IEnumerable<Dictionary<string, string>>? Group { get; set; }

    [JsonPropertyName("date")]
    public required DateTime Date { get; set; }

    [JsonPropertyName("totalAmount")]
    public required double TotalAmount { get; set; }

    [JsonPropertyName("totalCount")]
    public required int TotalCount { get; set; }

    [JsonPropertyName("averageAmount")]
    public required double AverageAmount { get; set; }

    [JsonPropertyName("currency")]
    public required CurrencyCode Currency { get; set; }
}
