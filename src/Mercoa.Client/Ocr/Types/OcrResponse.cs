using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record OcrResponse
{
    [JsonPropertyName("invoice")]
    public required InvoiceResponse Invoice { get; set; }

    [JsonPropertyName("vendor")]
    public required CounterpartyResponse Vendor { get; set; }

    [JsonPropertyName("check")]
    public CheckResponse? Check { get; set; }

    [JsonPropertyName("bankAccount")]
    public BankAccountResponse? BankAccount { get; set; }
}
