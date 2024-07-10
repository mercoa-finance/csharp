using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class IndustryCodes
{
    [JsonPropertyName("mcc")]
    public string? Mcc { get; init; }
}
