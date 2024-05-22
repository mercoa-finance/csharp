using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class VendorTrigger
{
    [JsonPropertyName("vendorIds")]
    public List<string> VendorIds { get; init; }
}
