using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record TaxId
{
    [JsonPropertyName("ein")]
    public required Ein Ein { get; set; }
}
