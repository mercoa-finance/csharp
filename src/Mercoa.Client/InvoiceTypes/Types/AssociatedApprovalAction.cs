using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record AssociatedApprovalAction
{
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    [JsonPropertyName("action")]
    public required ApproverAction Action { get; set; }
}
