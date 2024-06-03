using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class ApprovalPolicyRequest
{
    /// <summary>
    /// List of triggers that will cause this policy to be evaluated. If no triggers are provided, the policy will be evaluated for all invoices.
    /// </summary>
    [JsonPropertyName("trigger")]
    public IEnumerable<Trigger> Trigger { get; init; }

    [JsonPropertyName("rule")]
    public Rule Rule { get; init; }

    /// <summary>
    /// The policy ID of the previous approval policy in the chain of policies. Use 'root' if no upstreamPolicyId is intended to be set.
    /// </summary>
    [JsonPropertyName("upstreamPolicyId")]
    public string UpstreamPolicyId { get; init; }
}
