using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class ApprovalRequest
{
    /// <summary>
    /// Comment associated with this approval action.
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; init; }

    [JsonPropertyName("userId")]
    public string UserId { get; init; }
}
