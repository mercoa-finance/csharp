using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class ProfileRequest
{
    /// <summary>
    /// If this entity is a business, set this field
    /// </summary>
    [JsonPropertyName("business")]
    public BusinessProfileRequest? Business { get; init; }

    /// <summary>
    /// If this entity is a individual, set this field
    /// </summary>
    [JsonPropertyName("individual")]
    public IndividualProfileRequest? Individual { get; init; }
}
