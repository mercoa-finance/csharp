using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record Responsibilities
{
    [JsonPropertyName("jobTitle")]
    public string? JobTitle { get; set; }

    /// <summary>
    /// Indicates whether this individual has significant management responsibilities within the business
    /// </summary>
    [JsonPropertyName("isController")]
    public bool? IsController { get; set; }

    /// <summary>
    /// Indicates whether this individual has an ownership stake of at least 25% in the business
    /// </summary>
    [JsonPropertyName("isOwner")]
    public bool? IsOwner { get; set; }

    /// <summary>
    /// Percentage of ownership in the business. Must be between 0 and 100.
    /// </summary>
    [JsonPropertyName("ownershipPercentage")]
    public int? OwnershipPercentage { get; set; }
}
