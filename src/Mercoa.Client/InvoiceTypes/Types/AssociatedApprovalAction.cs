using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class AssociatedApprovalAction
{
    [JsonPropertyName("userId")]
    public string UserId { get; init; }

    [JsonPropertyName("action")]
    public ApproverAction Action { get; init; }
}
