using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EmailTemplateRequest
{
    [JsonPropertyName("templateType")]
    public required EmailTemplateType TemplateType { get; set; }

    /// <summary>
    /// The name of the email template.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The subject of the email template.
    /// </summary>
    [JsonPropertyName("subject")]
    public required string Subject { get; set; }

    /// <summary>
    /// The HTML content of the email template.
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; set; }

    /// <summary>
    /// If true, this email template will be used as the default template for new invoices.
    /// </summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }
}
