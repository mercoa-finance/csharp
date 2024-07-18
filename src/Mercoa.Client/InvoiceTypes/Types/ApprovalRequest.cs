using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record ApprovalRequest
{
    /// <summary>
    /// Comment associated with this approval action.
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; init; }

    [JsonPropertyName("userId")]
    public required string UserId { get; init; }
}
