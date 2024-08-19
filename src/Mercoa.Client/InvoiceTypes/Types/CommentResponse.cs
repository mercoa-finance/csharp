using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CommentResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("text")]
    public required string Text { get; set; }

    [JsonPropertyName("user")]
    public EntityUserResponse? User { get; set; }

    /// <summary>
    /// If an approval action has triggered the generation of this comment, returns the associated approval action and actor
    /// </summary>
    [JsonPropertyName("associatedApprovalAction")]
    public AssociatedApprovalAction? AssociatedApprovalAction { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }
}
