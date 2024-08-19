using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<InvoiceOrderByField>))]
public enum InvoiceOrderByField
{
    [EnumMember(Value = "AMOUNT")]
    Amount,

    [EnumMember(Value = "DUE_DATE")]
    DueDate,

    [EnumMember(Value = "CREATED_AT")]
    CreatedAt,

    [EnumMember(Value = "UPDATED_AT")]
    UpdatedAt,

    [EnumMember(Value = "DEDUCTION_DATE")]
    DeductionDate,

    [EnumMember(Value = "INVOICE_DATE")]
    InvoiceDate,

    [EnumMember(Value = "SETTLEMENT_DATE")]
    SettlementDate,

    [EnumMember(Value = "INVOICE_NUMBER")]
    InvoiceNumber,

    [EnumMember(Value = "VENDOR_NAME")]
    VendorName,

    [EnumMember(Value = "PAYER_NAME")]
    PayerName,

    [EnumMember(Value = "NEXT_PAYMENT_DATE")]
    NextPaymentDate
}
