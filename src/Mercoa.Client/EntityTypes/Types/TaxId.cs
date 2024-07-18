using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record TaxId
{
    [JsonPropertyName("ein")]
    public required Ein Ein { get; init; }
}
