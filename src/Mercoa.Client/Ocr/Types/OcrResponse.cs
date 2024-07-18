using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record OcrResponse
{
    [JsonPropertyName("invoice")]
    public required InvoiceResponse Invoice { get; init; }

    [JsonPropertyName("vendor")]
    public required CounterpartyResponse Vendor { get; init; }

    [JsonPropertyName("check")]
    public CheckResponse? Check { get; init; }

    [JsonPropertyName("bankAccount")]
    public BankAccountResponse? BankAccount { get; init; }
}
