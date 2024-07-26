using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record EntityResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("email")]
    public required string Email { get; init; }

    /// <summary>
    /// The ID used to identify this entity in your system
    /// </summary>
    [JsonPropertyName("foreignId")]
    public string? ForeignId { get; init; }

    /// <summary>
    /// Local-part/username of the email address to which to send invoices to be added to the Invoice Inbox.
    /// </summary>
    [JsonPropertyName("emailTo")]
    public string? EmailTo { get; init; }

    /// <summary>
    /// Email inbox alias addresses. Used when forwarding emails to the emailTo address from an alias.
    /// </summary>
    [JsonPropertyName("emailToAlias")]
    public IEnumerable<string>? EmailToAlias { get; init; }

    /// <summary>
    /// True if this entity has a direct relationship with your organization.
    /// </summary>
    [JsonPropertyName("isCustomer")]
    public required bool IsCustomer { get; init; }

    [JsonPropertyName("accountType")]
    public required AccountType AccountType { get; init; }

    [JsonPropertyName("profile")]
    public required ProfileResponse Profile { get; init; }

    /// <summary>
    /// URL for the entity logo
    /// </summary>
    [JsonPropertyName("logo")]
    public string? Logo { get; init; }

    [JsonPropertyName("status")]
    public required EntityStatus Status { get; init; }

    /// <summary>
    /// True if this entity has accepted the terms of service.
    /// </summary>
    [JsonPropertyName("acceptedTos")]
    public required bool AcceptedTos { get; init; }

    /// <summary>
    /// True if this entity can pay invoices.
    /// </summary>
    [JsonPropertyName("isPayor")]
    public required bool IsPayor { get; init; }

    /// <summary>
    /// True if this entity can receive payments.
    /// </summary>
    [JsonPropertyName("isPayee")]
    public required bool IsPayee { get; init; }

    /// <summary>
    /// True if this entity is available as a payor to any entity on your platform. Otherwise this entity will only be available as a payor to entities that have a direct relationship with this entity.
    /// </summary>
    [JsonPropertyName("isNetworkPayor")]
    public required bool IsNetworkPayor { get; init; }

    /// <summary>
    /// True if this entity is available as a payee to any entity on your platform. Otherwise this entity will only be available as a payee to entities that have a direct relationship with this entity.
    /// </summary>
    [JsonPropertyName("isNetworkPayee")]
    public required bool IsNetworkPayee { get; init; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; init; }
}
