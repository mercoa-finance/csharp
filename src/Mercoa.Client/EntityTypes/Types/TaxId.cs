using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class TaxId
{
    [JsonPropertyName("ein")]
    public Ein Ein { get; init; }
}
