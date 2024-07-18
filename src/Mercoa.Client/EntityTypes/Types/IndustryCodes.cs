using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record IndustryCodes
{
    [JsonPropertyName("mcc")]
    public string? Mcc { get; init; }
}
