using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record IndividualGovernmentId
{
    /// <summary>
    /// Full Social Security Number. Must be in the format 123-45-6789.
    /// </summary>
    [JsonPropertyName("ssn")]
    public required string Ssn { get; set; }
}
