using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record ProfileResponse
{
    /// <summary>
    /// Will be set if the entity is a business
    /// </summary>
    [JsonPropertyName("business")]
    public BusinessProfileResponse? Business { get; set; }

    /// <summary>
    /// Will be set if the entity is a individual
    /// </summary>
    [JsonPropertyName("individual")]
    public IndividualProfileResponse? Individual { get; set; }
}
