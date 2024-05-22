using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class CounterpartyInvoiceMetricsResponse
{
    [JsonPropertyName("totalCount")]
    public int TotalCount { get; init; }

    [JsonPropertyName("totalAmount")]
    public double TotalAmount { get; init; }

    [JsonPropertyName("statuses")]
    public List<CounterpartyInvoiceMetricsStatusResponse> Statuses { get; init; }
}
