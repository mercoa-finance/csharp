using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record NotificationCustomizationRequest
{
    /// <summary>
    /// If set, notifications to this role will be sent to the email address of the entity. Set as empty string to disable.
    /// </summary>
    [JsonPropertyName("assumeRole")]
    public string? AssumeRole { get; set; }
}
