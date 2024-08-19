using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record ApprovalPolicyUpdateRequest
{
    [JsonPropertyName("trigger")]
    public IEnumerable<object>? Trigger { get; set; }

    [JsonPropertyName("rule")]
    public object? Rule { get; set; }

    [JsonPropertyName("upstreamPolicyId")]
    public string? UpstreamPolicyId { get; set; }
}
