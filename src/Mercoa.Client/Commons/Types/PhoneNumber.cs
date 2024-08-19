using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record PhoneNumber
{
    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; set; }

    [JsonPropertyName("number")]
    public required string Number { get; set; }
}
