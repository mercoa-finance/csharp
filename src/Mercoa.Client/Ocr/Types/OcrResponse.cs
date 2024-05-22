using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class OcrResponse
{
    [JsonPropertyName("invoice")]
    public InvoiceResponse Invoice { get; init; }

    [JsonPropertyName("vendor")]
    public EntityResponse Vendor { get; init; }

    [JsonPropertyName("check")]
    public CheckResponse? Check { get; init; }

    [JsonPropertyName("bankAccount")]
    public BankAccountResponse? BankAccount { get; init; }
}
