using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class MetadataCustomizationRequest
{
    /// <summary>
    /// The key of the metadata field. This must be defined at the organization level, otherwise an error will be returned.
    /// </summary>
    [JsonPropertyName("key")]
    public string Key { get; init; }

    /// <summary>
    /// If true, this field will not be available to the entity.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool Disabled { get; init; }
}
