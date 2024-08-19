using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record InvoiceFeesResponse
{
    /// <summary>
    /// Fee charged to the platform (C1) for processing the source payment method. For example, credit card interchange and acquiring fees.
    /// </summary>
    [JsonPropertyName("sourcePaymentMethodFee")]
    public required double SourcePaymentMethodFee { get; set; }

    /// <summary>
    /// Fee charged to the payer (C2).
    /// </summary>
    [JsonPropertyName("sourcePlatformMarkupFee")]
    public required double SourcePlatformMarkupFee { get; set; }

    /// <summary>
    /// Fee charged to the platform (C1) for processing the destination payment method. For example, postage for a check payment.
    /// </summary>
    [JsonPropertyName("destinationPaymentMethodFee")]
    public required double DestinationPaymentMethodFee { get; set; }

    /// <summary>
    /// Fee charged to the payee (C3).
    /// </summary>
    [JsonPropertyName("destinationPlatformMarkupFee")]
    public required double DestinationPlatformMarkupFee { get; set; }
}
