using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class IndividualGovernmentId
{
    /// <summary>
    /// Full Social Security Number. Must be in the format 123-45-6789.
    /// </summary>
    [JsonPropertyName("ssn")]
    public string Ssn { get; init; }
}
