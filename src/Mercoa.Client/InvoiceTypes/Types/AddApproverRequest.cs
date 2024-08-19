using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record AddApproverRequest
{
    /// <summary>
    /// The identifier for the approval slot this user is assigned to.
    /// </summary>
    [JsonPropertyName("approvalSlotId")]
    public string? ApprovalSlotId { get; set; }

    [JsonPropertyName("userId")]
    public required string UserId { get; set; }
}
