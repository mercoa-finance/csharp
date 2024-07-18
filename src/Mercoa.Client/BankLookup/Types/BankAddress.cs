using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record BankAddress
{
    [JsonPropertyName("address")]
    public required string Address { get; init; }

    [JsonPropertyName("city")]
    public required string City { get; init; }

    [JsonPropertyName("state")]
    public required string State { get; init; }

    [JsonPropertyName("postalCode")]
    public required string PostalCode { get; init; }

    [JsonPropertyName("postalCodeExtension")]
    public required string PostalCodeExtension { get; init; }
}
