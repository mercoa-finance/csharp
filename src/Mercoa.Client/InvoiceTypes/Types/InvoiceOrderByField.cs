using System.Runtime.Serialization;

namespace Mercoa.Client;

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

    [EnumMember(Value = "INVOICE_NUMBER")]
    InvoiceNumber,

    [EnumMember(Value = "VENDOR_NAME")]
    VendorName,

    [EnumMember(Value = "PAYER_NAME")]
    PayerName
}
