using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<InvoiceMetricsPerDateFrequency>))]
public enum InvoiceMetricsPerDateFrequency
{
    [EnumMember(Value = "DAILY")]
    Daily,

    [EnumMember(Value = "WEEKLY")]
    Weekly,

    [EnumMember(Value = "MONTHLY")]
    Monthly,

    [EnumMember(Value = "YEARLY")]
    Yearly
}
