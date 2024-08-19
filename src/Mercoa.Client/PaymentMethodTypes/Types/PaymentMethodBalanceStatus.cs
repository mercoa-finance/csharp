using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<PaymentMethodBalanceStatus>))]
public enum PaymentMethodBalanceStatus
{
    [EnumMember(Value = "AVAILABLE")]
    Available,

    [EnumMember(Value = "UNAVAILABLE")]
    Unavailable,

    [EnumMember(Value = "ERROR")]
    Error
}
