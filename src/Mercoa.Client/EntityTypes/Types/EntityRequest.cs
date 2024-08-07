using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record EntityRequest
{
    /// <summary>
    /// The ID used to identify this entity in your system. This ID must be unique across all entities in your system.
    /// </summary>
    [JsonPropertyName("foreignId")]
    public string? ForeignId { get; init; }

    /// <summary>
    /// Sets the email address to which to send invoices to be added to the Invoice Inbox. Only provide the local-part/username of the email address, do not include the @domain.com
    /// </summary>
    [JsonPropertyName("emailTo")]
    public string? EmailTo { get; init; }

    /// <summary>
    /// Email inbox alias addresses. Used when forwarding emails to the emailTo address from an alias. Include the full email address.
    /// </summary>
    [JsonPropertyName("emailToAlias")]
    public IEnumerable<string>? EmailToAlias { get; init; }

    /// <summary>
    /// If this entity has a direct relationship with your organization (e.g your direct customer or client), set this to true. Otherwise, set to false (e.g your customer's vendors).
    /// </summary>
    [JsonPropertyName("isCustomer")]
    public required bool IsCustomer { get; init; }

    [JsonPropertyName("accountType")]
    public required AccountType AccountType { get; init; }

    [JsonPropertyName("profile")]
    public required ProfileRequest Profile { get; init; }

    /// <summary>
    /// If this entity will be paying invoices, set this to true.
    /// </summary>
    [JsonPropertyName("isPayor")]
    public required bool IsPayor { get; init; }

    /// <summary>
    /// If this entity will be receiving payments, set this to true.
    /// </summary>
    [JsonPropertyName("isPayee")]
    public required bool IsPayee { get; init; }

    /// <summary>
    /// Control if this entity should be available as a payor to any entity on your platform. If set to false, this entity will only be available as a payor to entities that have a direct relationship with this entity. Defaults to false.
    /// </summary>
    [JsonPropertyName("isNetworkPayor")]
    public bool? IsNetworkPayor { get; init; }

    /// <summary>
    /// Control if this entity should be available as a payee to any entity on your platform. If set to false, this entity will only be available as a payee to entities that have a direct relationship with this entity. Defaults to false.
    /// </summary>
    [JsonPropertyName("isNetworkPayee")]
    public bool? IsNetworkPayee { get; init; }

    /// <summary>
    /// Base64 encoded PNG image data for the entity logo. Max size 100KB.
    /// </summary>
    [JsonPropertyName("logo")]
    public string? Logo { get; init; }
}
