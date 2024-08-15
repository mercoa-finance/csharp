using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<PaymentMonthRepeatType>))]
public enum PaymentMonthRepeatType
{
    [EnumMember(Value = "start")]
    Start,

    [EnumMember(Value = "end")]
    End
}
