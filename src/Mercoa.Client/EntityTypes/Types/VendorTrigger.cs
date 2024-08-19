using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record VendorTrigger
{
    [JsonPropertyName("vendorIds")]
    public IEnumerable<string> VendorIds { get; set; } = new List<string>();
}
