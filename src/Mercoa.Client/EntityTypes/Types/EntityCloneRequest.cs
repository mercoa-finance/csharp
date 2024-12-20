using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityCloneRequest
{
    /// <summary>
    /// The ID or ForeignId of the entity to clone.
    /// </summary>
    [JsonPropertyName("createFromId")]
    public required string CreateFromId { get; set; }

    /// <summary>
    /// The ID used to identify this entity in your system. This ID must be unique across all entities in your system.
    /// </summary>
    [JsonPropertyName("foreignId")]
    public string? ForeignId { get; set; }

    /// <summary>
    /// Sets the email address to which to send invoices to be added to the Invoice Inbox. Only provide the local-part/username of the email address, do not include the @domain.com
    /// </summary>
    [JsonPropertyName("emailTo")]
    public string? EmailTo { get; set; }

    /// <summary>
    /// Email inbox alias addresses. Used when forwarding emails to the emailTo address from an alias. Include the full email address.
    /// </summary>
    [JsonPropertyName("emailToAlias")]
    public IEnumerable<string>? EmailToAlias { get; set; }

    /// <summary>
    /// Base64 encoded PNG image data for the entity logo. Max size 100KB.
    /// </summary>
    [JsonPropertyName("logo")]
    public string? Logo { get; set; }

    /// <summary>
    /// Simple key/value metadata associated with this entity. For more complex metadata, use the Metadata API.
    /// </summary>
    [JsonPropertyName("metadata")]
    public Dictionary<string, string>? Metadata { get; set; }
}
