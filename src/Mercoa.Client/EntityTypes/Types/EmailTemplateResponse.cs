using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EmailTemplateResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The ID of the entity that this email template is associated with.
    /// </summary>
    [JsonPropertyName("entityId")]
    public required string EntityId { get; set; }

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
    /// True if this email template is the default template for new invoices.
    /// </summary>
    [JsonPropertyName("isDefault")]
    public required bool IsDefault { get; set; }
}
