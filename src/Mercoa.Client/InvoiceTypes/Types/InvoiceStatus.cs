using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<InvoiceStatus>))]
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
