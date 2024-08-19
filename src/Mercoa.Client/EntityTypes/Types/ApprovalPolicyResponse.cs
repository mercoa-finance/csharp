using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record ApprovalPolicyResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("trigger")]
    public IEnumerable<object> Trigger { get; set; } = new List<object>();

    [JsonPropertyName("rule")]
    public required object Rule { get; set; }

    [JsonPropertyName("upstreamPolicyId")]
    public required string UpstreamPolicyId { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }
}
