using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record Responsibilities
{
    [JsonPropertyName("jobTitle")]
    public string? JobTitle { get; init; }

    /// <summary>
    /// Indicates whether this individual has significant management responsibilities within the business
    /// </summary>
    [JsonPropertyName("isController")]
    public bool? IsController { get; init; }

    /// <summary>
    /// Indicates whether this individual has an ownership stake of at least 25% in the business
    /// </summary>
    [JsonPropertyName("isOwner")]
    public bool? IsOwner { get; init; }

    /// <summary>
    /// Percentage of ownership in the business. Must be between 0 and 100.
    /// </summary>
    [JsonPropertyName("ownershipPercentage")]
    public int? OwnershipPercentage { get; init; }
}
