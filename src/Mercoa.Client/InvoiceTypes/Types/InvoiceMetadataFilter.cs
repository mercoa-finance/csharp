using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record InvoiceMetadataFilter
{
    [JsonPropertyName("key")]
    public required string Key { get; init; }

    [JsonPropertyName("value")]
    public required string Value { get; init; }
}
