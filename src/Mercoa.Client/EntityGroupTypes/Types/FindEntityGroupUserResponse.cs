using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record FindEntityGroupUserResponse
{
    /// <summary>
    /// Total number of users for the given filters. This value is not limited by the limit parameter. It is provided so that you can determine how many pages of results are available.
    /// </summary>
    [JsonPropertyName("count")]
    public required int Count { get; set; }

    /// <summary>
    /// True if there are more users available for the given filters.
    /// </summary>
    [JsonPropertyName("hasMore")]
    public required bool HasMore { get; set; }

    [JsonPropertyName("data")]
    public IEnumerable<EntityGroupUserResponse> Data { get; set; } =
        new List<EntityGroupUserResponse>();
}
