using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record MetadataCustomizationRequest
{
    /// <summary>
    /// The key of the metadata field. This must be defined at the organization level, otherwise an error will be returned.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; init; }

    /// <summary>
    /// If true, this field will not be available to the entity.
    /// </summary>
    [JsonPropertyName("disabled")]
    public required bool Disabled { get; init; }
}
