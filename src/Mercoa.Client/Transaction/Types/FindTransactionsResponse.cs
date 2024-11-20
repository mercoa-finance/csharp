using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record FindTransactionsResponse
{
    [JsonPropertyName("count")]
    public required int Count { get; set; }

    [JsonPropertyName("hasMore")]
    public required bool HasMore { get; set; }

    [JsonPropertyName("data")]
    public IEnumerable<object> Data { get; set; } = new List<object>();
}
