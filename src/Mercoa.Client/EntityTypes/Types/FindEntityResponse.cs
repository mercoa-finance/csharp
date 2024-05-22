using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class FindEntityResponse
{
    /// <summary>
    /// Total number of entities for the given filters. This value is not limited by the limit parameter. It is provided so that you can determine how many pages of results are available.
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; init; }

    /// <summary>
    /// True if there are more entities available for the given filters.
    /// </summary>
    [JsonPropertyName("hasMore")]
    public bool HasMore { get; init; }

    [JsonPropertyName("data")]
    public List<EntityWithPaymentMethodResponse> Data { get; init; }
}
