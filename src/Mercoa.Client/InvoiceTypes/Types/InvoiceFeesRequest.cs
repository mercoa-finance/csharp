using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class InvoiceFeesRequest
{
    /// <summary>
    /// Fee charged to the payer (C2).
    /// </summary>
    [JsonPropertyName("sourcePlatformMarkupFee")]
    public double SourcePlatformMarkupFee { get; init; }

    /// <summary>
    /// Fee charged to the payee (C3).
    /// </summary>
    [JsonPropertyName("destinationPlatformMarkupFee")]
    public double DestinationPlatformMarkupFee { get; init; }
}
