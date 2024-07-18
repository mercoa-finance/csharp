using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EmailLog
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("subject")]
    public required string Subject { get; init; }

    [JsonPropertyName("from")]
    public required string From { get; init; }

    [JsonPropertyName("to")]
    public required string To { get; init; }

    [JsonPropertyName("htmlBody")]
    public required string HtmlBody { get; init; }

    [JsonPropertyName("textBody")]
    public required string TextBody { get; init; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; init; }

    [JsonPropertyName("invoiceId")]
    public string? InvoiceId { get; init; }
}
