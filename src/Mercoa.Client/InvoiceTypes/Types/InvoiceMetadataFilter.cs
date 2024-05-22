using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class InvoiceMetadataFilter
{
    [JsonPropertyName("key")]
    public string Key { get; init; }

    [JsonPropertyName("value")]
    public string Value { get; init; }
}
