using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record FindInvoiceTemplateResponse
{
    /// <summary>
    /// Total number of invoice templates for the given filters. This value is not limited by the limit parameter. It is provided so that you can determine how many pages of results are available.
    /// </summary>
    [JsonPropertyName("count")]
    public required int Count { get; set; }

    /// <summary>
    /// True if there are more invoice templates available for the given filters.
    /// </summary>
    [JsonPropertyName("hasMore")]
    public required bool HasMore { get; set; }

    [JsonPropertyName("data")]
    public IEnumerable<InvoiceTemplateResponse> Data { get; set; } =
        new List<InvoiceTemplateResponse>();
}
