using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record ApprovalPolicyResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("trigger")]
    public IEnumerable<object> Trigger { get; init; } = new List<object>();

    [JsonPropertyName("rule")]
    public required object Rule { get; init; }

    [JsonPropertyName("upstreamPolicyId")]
    public required string UpstreamPolicyId { get; init; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; init; }
}
