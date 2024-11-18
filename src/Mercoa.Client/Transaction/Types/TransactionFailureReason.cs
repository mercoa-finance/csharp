using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record TransactionFailureReason
{
    /// <summary>
    /// The failure reason code.
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// The failure reason description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}
