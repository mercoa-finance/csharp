using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum InvoiceStatus
{
    [EnumMember(Value = "DRAFT")]
    Draft,

    [EnumMember(Value = "NEW")]
    New,

    [EnumMember(Value = "APPROVED")]
    Approved,

    [EnumMember(Value = "SCHEDULED")]
    Scheduled,

    [EnumMember(Value = "PENDING")]
    Pending,

    [EnumMember(Value = "PAID")]
    Paid,

    [EnumMember(Value = "ARCHIVED")]
    Archived,

    [EnumMember(Value = "REFUSED")]
    Refused,

    [EnumMember(Value = "CANCELED")]
    Canceled,

    [EnumMember(Value = "FAILED")]
    Failed
}
