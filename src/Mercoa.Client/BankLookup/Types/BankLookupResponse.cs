using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record BankLookupResponse
{
    [JsonPropertyName("bankName")]
    public required string BankName { get; set; }

    [JsonPropertyName("bankAddress")]
    public required BankAddress BankAddress { get; set; }
}
