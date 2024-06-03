using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class EmailLog
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("subject")]
    public string Subject { get; init; }

    [JsonPropertyName("from")]
    public string From { get; init; }

    [JsonPropertyName("to")]
    public string To { get; init; }

    [JsonPropertyName("htmlBody")]
    public string HtmlBody { get; init; }

    [JsonPropertyName("textBody")]
    public string TextBody { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("invoiceId")]
    public string? InvoiceId { get; init; }
}
