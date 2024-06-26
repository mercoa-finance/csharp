using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class BankLookupResponse
{
    [JsonPropertyName("bankName")]
    public string BankName { get; init; }

    [JsonPropertyName("bankAddress")]
    public BankAddress BankAddress { get; init; }
}
