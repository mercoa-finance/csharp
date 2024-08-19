using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CommentRequest
{
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    [JsonPropertyName("userId")]
    public string? UserId { get; set; }
}
