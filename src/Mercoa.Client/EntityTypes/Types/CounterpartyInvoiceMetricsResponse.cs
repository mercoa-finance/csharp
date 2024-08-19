using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CounterpartyInvoiceMetricsResponse
{
    [JsonPropertyName("totalCount")]
    public required int TotalCount { get; set; }

    [JsonPropertyName("totalAmount")]
    public required double TotalAmount { get; set; }

    [JsonPropertyName("statuses")]
    public IEnumerable<CounterpartyInvoiceMetricsStatusResponse> Statuses { get; set; } =
        new List<CounterpartyInvoiceMetricsStatusResponse>();
}
