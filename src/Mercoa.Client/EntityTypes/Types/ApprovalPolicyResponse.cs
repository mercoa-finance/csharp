using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class ApprovalPolicyResponse
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("trigger")]
    public IEnumerable<Trigger> Trigger { get; init; }

    [JsonPropertyName("rule")]
    public Rule Rule { get; init; }

    [JsonPropertyName("upstreamPolicyId")]
    public string UpstreamPolicyId { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }
}
