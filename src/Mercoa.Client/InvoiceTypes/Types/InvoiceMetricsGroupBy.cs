using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<InvoiceMetricsGroupBy>))]
public enum InvoiceMetricsGroupBy
{
    [EnumMember(Value = "STATUS")]
    Status
}
