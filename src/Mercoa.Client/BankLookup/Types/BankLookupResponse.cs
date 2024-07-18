using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record BankLookupResponse
{
    [JsonPropertyName("bankName")]
    public required string BankName { get; init; }

    [JsonPropertyName("bankAddress")]
    public required BankAddress BankAddress { get; init; }
}
