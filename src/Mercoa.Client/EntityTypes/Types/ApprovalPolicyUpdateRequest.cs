using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record ApprovalPolicyUpdateRequest
{
    [JsonPropertyName("trigger")]
    public IEnumerable<object>? Trigger { get; init; }

    [JsonPropertyName("rule")]
    public object? Rule { get; init; }

    [JsonPropertyName("upstreamPolicyId")]
    public string? UpstreamPolicyId { get; init; }
}
