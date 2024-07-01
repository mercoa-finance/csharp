using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<CustomPaymentMethodFeeType>))]
public enum CustomPaymentMethodFeeType
{
    [EnumMember(Value = "none")]
    None,

    [EnumMember(Value = "flat")]
    Flat,

    [EnumMember(Value = "percentage")]
    Percentage
}
