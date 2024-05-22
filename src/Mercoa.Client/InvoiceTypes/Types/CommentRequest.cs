using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class CommentRequest
{
    [JsonPropertyName("text")]
    public string Text { get; init; }

    [JsonPropertyName("userId")]
    public string? UserId { get; init; }
}
