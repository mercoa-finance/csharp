using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record CommentResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("text")]
    public required string Text { get; init; }

    [JsonPropertyName("user")]
    public EntityUserResponse? User { get; init; }

    /// <summary>
    /// If an approval action has triggered the generation of this comment, returns the associated approval action and actor
    /// </summary>
    [JsonPropertyName("associatedApprovalAction")]
    public AssociatedApprovalAction? AssociatedApprovalAction { get; init; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; init; }
}
