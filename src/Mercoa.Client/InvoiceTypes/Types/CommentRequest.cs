using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CommentRequest
{
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    /// <summary>
    /// The ID or the Foreign ID of the user who created the comment.
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }
}
