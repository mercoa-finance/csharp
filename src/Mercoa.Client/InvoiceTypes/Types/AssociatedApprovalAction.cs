using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record AssociatedApprovalAction
{
    [JsonPropertyName("userId")]
    public required string UserId { get; init; }

    [JsonPropertyName("action")]
    public required ApproverAction Action { get; init; }
}
