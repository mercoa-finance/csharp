using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class EmailLogResponse
{
    /// <summary>
    /// Total number of logs for the given filters. This value is not limited by the limit parameter. It is provided so that you can determine how many pages of results are available.
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; init; }

    /// <summary>
    /// True if there are more logs available for the given filters.
    /// </summary>
    [JsonPropertyName("hasMore")]
    public bool HasMore { get; init; }

    [JsonPropertyName("data")]
    public List<EmailLog> Data { get; init; }
}
