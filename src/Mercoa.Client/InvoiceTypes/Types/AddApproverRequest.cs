using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class AddApproverRequest
{
    /// <summary>
    /// The identifier for the approval slot this user is assigned to.
    /// </summary>
    [JsonPropertyName("approvalSlotId")]
    public string? ApprovalSlotId { get; init; }

    [JsonPropertyName("userId")]
    public string UserId { get; init; }
}
