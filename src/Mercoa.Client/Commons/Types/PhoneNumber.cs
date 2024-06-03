using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class PhoneNumber
{
    [JsonPropertyName("countryCode")]
    public string CountryCode { get; init; }

    [JsonPropertyName("number")]
    public string Number { get; init; }
}
