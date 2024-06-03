using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class TaxId
{
    [JsonPropertyName("ein")]
    public Ein Ein { get; init; }
}
