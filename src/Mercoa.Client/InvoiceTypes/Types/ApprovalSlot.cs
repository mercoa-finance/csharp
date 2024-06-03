using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class ApprovalSlot
{
    /// <summary>
    /// The identifier for the approval policy this slot is associated with.
    /// </summary>
    [JsonPropertyName("approvalPolicyId")]
    public string ApprovalPolicyId { get; init; }

    /// <summary>
    /// The identifier for this approval slot
    /// </summary>
    [JsonPropertyName("approvalSlotId")]
    public string ApprovalSlotId { get; init; }

    [JsonPropertyName("assignedUserId")]
    public string? AssignedUserId { get; init; }

    [JsonPropertyName("action")]
    public ApproverAction Action { get; init; }

    [JsonPropertyName("eligibleRoles")]
    public IEnumerable<string> EligibleRoles { get; init; }

    [JsonPropertyName("eligibleUserIds")]
    public IEnumerable<string> EligibleUserIds { get; init; }

    /// <summary>
    /// Either the date the invoice was created, date the approver was assigned, or date of last action by approver, whichever is latest.
    /// </summary>
    [JsonPropertyName("date")]
    public DateTime Date { get; init; }
}
