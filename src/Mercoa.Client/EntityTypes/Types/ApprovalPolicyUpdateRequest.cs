using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class ApprovalPolicyUpdateRequest
{
    [JsonPropertyName("trigger")]
    public IEnumerable<Trigger>? Trigger { get; init; }

    [JsonPropertyName("rule")]
    public Rule? Rule { get; init; }

    [JsonPropertyName("upstreamPolicyId")]
    public string? UpstreamPolicyId { get; init; }
}
