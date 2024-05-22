using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum InvoiceMetricsPerDateGroupBy
{
    [EnumMember(Value = "CREATION_DATE")]
    CreationDate,

    [EnumMember(Value = "DUE_DATE")]
    DueDate,

    [EnumMember(Value = "INVOICE_DATE")]
    InvoiceDate,

    [EnumMember(Value = "DEDUCTION_DATE")]
    DeductionDate
}
