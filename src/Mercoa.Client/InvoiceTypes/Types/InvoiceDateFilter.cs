using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<InvoiceDateFilter>))]
public enum InvoiceDateFilter
{
    [EnumMember(Value = "INVOICE_DATE")]
    InvoiceDate,

    [EnumMember(Value = "DEDUCTION_DATE")]
    DeductionDate,

    [EnumMember(Value = "DUE_DATE")]
    DueDate,

    [EnumMember(Value = "SETTLEMENT_DATE")]
    SettlementDate,

    [EnumMember(Value = "CREATED_AT")]
    CreatedAt,

    [EnumMember(Value = "UPDATED_AT")]
    UpdatedAt
}
