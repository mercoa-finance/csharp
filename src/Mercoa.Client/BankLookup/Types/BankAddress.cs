using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record BankAddress
{
    [JsonPropertyName("address")]
    public required string Address { get; set; }

    [JsonPropertyName("city")]
    public required string City { get; set; }

    [JsonPropertyName("state")]
    public required string State { get; set; }

    [JsonPropertyName("postalCode")]
    public required string PostalCode { get; set; }

    [JsonPropertyName("postalCodeExtension")]
    public required string PostalCodeExtension { get; set; }
}
