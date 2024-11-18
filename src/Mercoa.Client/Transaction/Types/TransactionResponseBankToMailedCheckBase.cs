using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record TransactionResponseBankToMailedCheckBase
{
    /// <summary>
    /// The number of the check
    /// </summary>
    [JsonPropertyName("checkNumber")]
    public required int CheckNumber { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("status")]
    public required TransactionStatus Status { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }
}
