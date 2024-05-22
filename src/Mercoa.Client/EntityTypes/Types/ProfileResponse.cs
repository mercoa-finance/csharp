using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class ProfileResponse
{
    /// <summary>
    /// Will be set if the entity is a business
    /// </summary>
    [JsonPropertyName("business")]
    public BusinessProfileResponse? Business { get; init; }

    /// <summary>
    /// Will be set if the entity is a individual
    /// </summary>
    [JsonPropertyName("individual")]
    public IndividualProfileResponse? Individual { get; init; }
}
