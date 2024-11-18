using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record ApprovalSlot
{
    /// <summary>
    /// The identifier for the approval policy this slot is associated with.
    /// </summary>
    [JsonPropertyName("approvalPolicyId")]
    public required string ApprovalPolicyId { get; set; }

    /// <summary>
    /// The identifier for this approval slot
    /// </summary>
    [JsonPropertyName("approvalSlotId")]
    public required string ApprovalSlotId { get; set; }

    /// <summary>
    /// The ID of the user who is assigned to the approval slot. If undefined, the approval slot is assigned to all eligible approvers.
    /// </summary>
    [JsonPropertyName("assignedUserId")]
    public string? AssignedUserId { get; set; }

    [JsonPropertyName("action")]
    public required ApproverAction Action { get; set; }

    [JsonPropertyName("eligibleRoles")]
    public IEnumerable<string> EligibleRoles { get; set; } = new List<string>();

    [JsonPropertyName("eligibleUserIds")]
    public IEnumerable<string> EligibleUserIds { get; set; } = new List<string>();

    /// <summary>
    /// Either the date the invoice was created, date the approver was assigned, or date of last action by approver, whichever is latest.
    /// </summary>
    [JsonPropertyName("date")]
    public required DateTime Date { get; set; }
}
