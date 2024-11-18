using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CalculateVendorCreditUsageResponse
{
    /// <summary>
    /// Remaining amount on the invoice after vendor credits are applied in major units.
    /// </summary>
    [JsonPropertyName("remainingAmount")]
    public required double RemainingAmount { get; set; }

    /// <summary>
    /// Currency code for the amount. Defaults to USD.
    /// </summary>
    [JsonPropertyName("currency")]
    public required CurrencyCode Currency { get; set; }

    /// <summary>
    /// Vendor credits that will be applied to the invoice. The objects returned represent the states each vendor credit will be in AFTER they are applied to the invoice, not their current states.
    /// </summary>
    [JsonPropertyName("vendorCredits")]
    public IEnumerable<VendorCreditResponse> VendorCredits { get; set; } =
        new List<VendorCreditResponse>();
}
