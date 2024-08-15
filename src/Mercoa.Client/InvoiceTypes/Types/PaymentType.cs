using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<PaymentType>))]
public enum PaymentType
{
    [EnumMember(Value = "oneTime")]
    OneTime,

    [EnumMember(Value = "recurring")]
    Recurring
}
