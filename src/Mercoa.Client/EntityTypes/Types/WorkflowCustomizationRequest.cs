using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record WorkflowCustomizationRequest
{
    /// <summary>
    /// If true, the invoice will be automatically advanced to the furthest stage in the payment workflow. For example, if the invoice is APPROVED, but has all necessary data to move to SCHEDULED, it will be advanced to SCHEDULED.
    /// </summary>
    [JsonPropertyName("autoAdvanceInvoiceStatus")]
    public bool? AutoAdvanceInvoiceStatus { get; set; }
}
