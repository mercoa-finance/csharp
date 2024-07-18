using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record CounterpartyInvoiceMetricsResponse
{
    [JsonPropertyName("totalCount")]
    public required int TotalCount { get; init; }

    [JsonPropertyName("totalAmount")]
    public required double TotalAmount { get; init; }

    [JsonPropertyName("statuses")]
    public IEnumerable<CounterpartyInvoiceMetricsStatusResponse> Statuses { get; init; } =
        new List<CounterpartyInvoiceMetricsStatusResponse>();
}
