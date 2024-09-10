using System.Text.Json.Serialization;
using Mercoa.Client.Core;
using OneOf;

#nullable enable

namespace Mercoa.Client;

public record MetadataFilter
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// If multiple values are provided, the filter will match if any of the values match (OR filter)
    /// </summary>
    [JsonPropertyName("value")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, IEnumerable<string>>>))]
    public required OneOf<string, IEnumerable<string>> Value { get; set; }
}
