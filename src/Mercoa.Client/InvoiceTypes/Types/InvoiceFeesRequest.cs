using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record InvoiceFeesRequest
{
    /// <summary>
    /// Fee charged to the payer (C2).
    /// </summary>
    [JsonPropertyName("sourcePlatformMarkupFee")]
    public required double SourcePlatformMarkupFee { get; init; }

    /// <summary>
    /// Fee charged to the payee (C3).
    /// </summary>
    [JsonPropertyName("destinationPlatformMarkupFee")]
    public required double DestinationPlatformMarkupFee { get; init; }
}
