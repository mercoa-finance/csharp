using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record TransactionResponseBankToBankWithInvoices
{
    /// <summary>
    /// Invoices associated with this transaction
    /// </summary>
    [JsonPropertyName("invoices")]
    public IEnumerable<InvoiceResponse> Invoices { get; set; } = new List<InvoiceResponse>();

    /// <summary>
    /// If the invoice failed to be paid, this field will be populated with the reason of failure.
    /// </summary>
    [JsonPropertyName("failureReason")]
    public TransactionFailureReason? FailureReason { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("status")]
    public required TransactionStatus Status { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }
}
