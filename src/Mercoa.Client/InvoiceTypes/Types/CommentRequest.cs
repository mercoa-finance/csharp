using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CommentRequest
{
    [JsonPropertyName("text")]
    public required string Text { get; init; }

    [JsonPropertyName("userId")]
    public string? UserId { get; init; }
}
