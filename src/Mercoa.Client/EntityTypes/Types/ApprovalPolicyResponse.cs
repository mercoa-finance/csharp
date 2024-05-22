using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class ApprovalPolicyResponse
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("trigger")]
    public List<Trigger> Trigger { get; init; }

    [JsonPropertyName("rule")]
    public Rule Rule { get; init; }

    [JsonPropertyName("upstreamPolicyId")]
    public string UpstreamPolicyId { get; init; }
}
