using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record FindNotificationResponse
{
    /// <summary>
    /// Total number of notifications for the given start and end date filters. This value is not limited by the limit parameter. It is provided so that you can determine how many pages of results are available.
    /// </summary>
    [JsonPropertyName("count")]
    public required int Count { get; init; }

    /// <summary>
    /// True if there are more notifications available for the given start and end date filters.
    /// </summary>
    [JsonPropertyName("hasMore")]
    public required bool HasMore { get; init; }

    [JsonPropertyName("data")]
    public IEnumerable<NotificationResponse> Data { get; init; } = new List<NotificationResponse>();
}
