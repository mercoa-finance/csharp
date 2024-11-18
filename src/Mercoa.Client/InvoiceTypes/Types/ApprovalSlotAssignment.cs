using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record ApprovalSlotAssignment
{
    /// <summary>
    /// The identifier for the approval slot this user is assigned to.
    /// </summary>
    [JsonPropertyName("approvalSlotId")]
    public required string ApprovalSlotId { get; set; }

    /// <summary>
    /// The ID of the user who is assigned to the approval slot. To assign all eligible users to an approval slot, use "ANY".
    /// </summary>
    [JsonPropertyName("assignedUserId")]
    public required string AssignedUserId { get; set; }
}
