using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record FindCounterpartiesResponse
{
    /// <summary>
    /// Total number of counterparties for the given filters. This value is not limited by the limit parameter. It is provided so that you can determine how many pages of results are available.
    /// </summary>
    [JsonPropertyName("count")]
    public required int Count { get; init; }

    /// <summary>
    /// True if there are more counterparties available for the given filters.
    /// </summary>
    [JsonPropertyName("hasMore")]
    public required bool HasMore { get; init; }

    [JsonPropertyName("data")]
    public IEnumerable<CounterpartyResponse> Data { get; init; } = new List<CounterpartyResponse>();
}
