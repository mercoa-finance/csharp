using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<InvoiceFailureType>))]
public enum InvoiceFailureType
{
    [EnumMember(Value = "SOURCE_PAYMENT_ERROR")]
    SourcePaymentError,

    [EnumMember(Value = "DESTINATION_PAYMENT_ERROR")]
    DestinationPaymentError,

    [EnumMember(Value = "REJECTED_HIGH_RISK")]
    RejectedHighRisk,

    [EnumMember(Value = "INSUFFICIENT_FUNDS")]
    InsufficientFunds,

    [EnumMember(Value = "PROCESSING_ERROR")]
    ProcessingError
}
