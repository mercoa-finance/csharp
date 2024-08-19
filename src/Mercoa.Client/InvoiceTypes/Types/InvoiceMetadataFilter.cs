using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record InvoiceMetadataFilter
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}
