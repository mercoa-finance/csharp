using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class CommentResponse
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("text")]
    public string Text { get; init; }

    [JsonPropertyName("user")]
    public EntityUserResponse? User { get; init; }

    /// <summary>
    /// If an approval action has triggered the generation of this comment, returns the associated approval action and actor
    /// </summary>
    [JsonPropertyName("associatedApprovalAction")]
    public AssociatedApprovalAction? AssociatedApprovalAction { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }
}
