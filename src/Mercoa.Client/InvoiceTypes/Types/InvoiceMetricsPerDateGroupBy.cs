using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<InvoiceMetricsPerDateGroupBy>))]
public enum InvoiceMetricsPerDateGroupBy
{
    [EnumMember(Value = "CREATION_DATE")]
    CreationDate,

    [EnumMember(Value = "DUE_DATE")]
    DueDate,

    [EnumMember(Value = "INVOICE_DATE")]
    InvoiceDate,

    [EnumMember(Value = "DEDUCTION_DATE")]
    DeductionDate,

    [EnumMember(Value = "NEXT_PAYMENT_DATE")]
    NextPaymentDate
}
