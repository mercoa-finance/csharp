using System.Runtime.Serialization;

namespace Mercoa.Client;

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
