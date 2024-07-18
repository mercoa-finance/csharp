using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record MetadataRegexValidationRule
{
    /// <summary>
    /// A regular expression that the value must match.
    /// </summary>
    [JsonPropertyName("regex")]
    public required string Regex { get; init; }

    /// <summary>
    /// The error message to display if the value does not match the regular expression.
    /// </summary>
    [JsonPropertyName("errorMessage")]
    public required string ErrorMessage { get; init; }
}
