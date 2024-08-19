using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record ProfileRequest
{
    /// <summary>
    /// If this entity is a business, set this field
    /// </summary>
    [JsonPropertyName("business")]
    public BusinessProfileRequest? Business { get; set; }

    /// <summary>
    /// If this entity is a individual, set this field
    /// </summary>
    [JsonPropertyName("individual")]
    public IndividualProfileRequest? Individual { get; set; }
}
