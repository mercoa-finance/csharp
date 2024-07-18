using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record TokenGenerationVendorOptions
{
    /// <summary>
    /// If true, the user will not be able to create new vendors.
    /// </summary>
    [JsonPropertyName("disableCreation")]
    public bool? DisableCreation { get; init; }

    [JsonPropertyName("network")]
    public required VendorNetwork Network { get; init; }
}
