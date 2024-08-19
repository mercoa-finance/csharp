using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record TokenGenerationVendorOptions
{
    /// <summary>
    /// If true, the user will not be able to create new vendors.
    /// </summary>
    [JsonPropertyName("disableCreation")]
    public bool? DisableCreation { get; set; }

    [JsonPropertyName("network")]
    public required VendorNetwork Network { get; set; }
}
