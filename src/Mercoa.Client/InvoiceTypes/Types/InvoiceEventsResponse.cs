using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record InvoiceEventsResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<InvoiceEvent> Data { get; set; } = new List<InvoiceEvent>();

    [JsonPropertyName("count")]
    public required int Count { get; set; }
}
