using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class Ein
{
    /// <summary>
    /// Must be in the format XX-XXXXXXX.
    /// </summary>
    [JsonPropertyName("number")]
    public string Number { get; init; }
}
