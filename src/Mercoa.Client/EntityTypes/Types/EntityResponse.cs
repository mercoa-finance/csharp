using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class EntityResponse
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("email")]
    public string Email { get; init; }

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
    public bool IsCustomer { get; init; }

    [JsonPropertyName("accountType")]
    public AccountType AccountType { get; init; }

    [JsonPropertyName("profile")]
    public ProfileResponse Profile { get; init; }

    [JsonPropertyName("status")]
    public EntityStatus Status { get; init; }

    /// <summary>
    /// True if this entity has accepted the terms of service.
    /// </summary>
    [JsonPropertyName("acceptedTos")]
    public bool AcceptedTos { get; init; }

    /// <summary>
    /// True if this entity can pay invoices.
    /// </summary>
    [JsonPropertyName("isPayor")]
    public bool IsPayor { get; init; }

    /// <summary>
    /// True if this entity can receive payments.
    /// </summary>
    [JsonPropertyName("isPayee")]
    public bool IsPayee { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }
}
