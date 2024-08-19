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

    [JsonPropertyName("assignedUserId")]
    public required string AssignedUserId { get; set; }
}
