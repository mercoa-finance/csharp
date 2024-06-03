using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class VendorTrigger
{
    [JsonPropertyName("vendorIds")]
    public IEnumerable<string> VendorIds { get; init; }
}
