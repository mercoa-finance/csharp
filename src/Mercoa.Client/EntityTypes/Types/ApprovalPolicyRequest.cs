using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record ApprovalPolicyRequest
{
    /// <summary>
    /// List of triggers that will cause this policy to be evaluated. If no triggers are provided, the policy will be evaluated for all invoices.
    /// </summary>
    [JsonPropertyName("trigger")]
    public IEnumerable<object> Trigger { get; set; } = new List<object>();

    [JsonPropertyName("rule")]
    public required object Rule { get; set; }

    /// <summary>
    /// The policy ID of the previous approval policy in the chain of policies. Use 'root' if no upstreamPolicyId is intended to be set.
    /// </summary>
    [JsonPropertyName("upstreamPolicyId")]
    public required string UpstreamPolicyId { get; set; }
}
