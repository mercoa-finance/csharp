using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class InvoiceFeesResponse
{
    /// <summary>
    /// Fee charged to the platform (C1) for processing the source payment method. For example, credit card interchange and acquiring fees.
    /// </summary>
    [JsonPropertyName("sourcePaymentMethodFee")]
    public double SourcePaymentMethodFee { get; init; }

    /// <summary>
    /// Fee charged to the payer (C2).
    /// </summary>
    [JsonPropertyName("sourcePlatformMarkupFee")]
    public double SourcePlatformMarkupFee { get; init; }

    /// <summary>
    /// Fee charged to the platform (C1) for processing the destination payment method. For example, postage for a check payment.
    /// </summary>
    [JsonPropertyName("destinationPaymentMethodFee")]
    public double DestinationPaymentMethodFee { get; init; }

    /// <summary>
    /// Fee charged to the payee (C3).
    /// </summary>
    [JsonPropertyName("destinationPlatformMarkupFee")]
    public double DestinationPlatformMarkupFee { get; init; }
}
