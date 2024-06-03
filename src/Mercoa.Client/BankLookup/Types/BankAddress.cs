using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class BankAddress
{
    [JsonPropertyName("address")]
    public string Address { get; init; }

    [JsonPropertyName("city")]
    public string City { get; init; }

    [JsonPropertyName("state")]
    public string State { get; init; }

    [JsonPropertyName("postalCode")]
    public string PostalCode { get; init; }

    [JsonPropertyName("postalCodeExtension")]
    public string PostalCodeExtension { get; init; }
}
