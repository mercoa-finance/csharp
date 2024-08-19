using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record Ein
{
    /// <summary>
    /// Must be in the format XX-XXXXXXX.
    /// </summary>
    [JsonPropertyName("number")]
    public required string Number { get; set; }
}
