using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record PlaidProcessorTokenRequest
{
    /// <summary>
    /// Plaid processor token for the account. If you already have a processor token for the account (for example, you have linked the account to your app already), use this instead of publicToken.
    /// </summary>
    [JsonPropertyName("processorToken")]
    public required string ProcessorToken { get; set; }
}
