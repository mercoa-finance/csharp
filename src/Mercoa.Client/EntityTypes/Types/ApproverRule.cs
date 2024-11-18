using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record ApproverRule
{
    /// <summary>
    /// Number of approvals required to approve an invoice
    /// </summary>
    [JsonPropertyName("numApprovers")]
    public required int NumApprovers { get; set; }

    /// <summary>
    /// List of users or roles that should be used to determine eligible approvers
    /// </summary>
    [JsonPropertyName("identifierList")]
    public required object IdentifierList { get; set; }

    /// <summary>
    /// If true, the policy will automatically assign approvers to the invoice. If more than one approver is eligible, the policy will assign all eligible approvers to the invoice.
    /// </summary>
    [JsonPropertyName("autoAssign")]
    public bool? AutoAssign { get; set; }
}
