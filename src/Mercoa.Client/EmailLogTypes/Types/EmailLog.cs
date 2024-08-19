using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EmailLog
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("subject")]
    public required string Subject { get; set; }

    [JsonPropertyName("from")]
    public required string From { get; set; }

    [JsonPropertyName("to")]
    public required string To { get; set; }

    [JsonPropertyName("htmlBody")]
    public required string HtmlBody { get; set; }

    [JsonPropertyName("textBody")]
    public required string TextBody { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("invoiceId")]
    public string? InvoiceId { get; set; }
}
