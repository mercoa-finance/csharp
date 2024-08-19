using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<CheckDeliveryMethod>))]
public enum CheckDeliveryMethod
{
    [EnumMember(Value = "PRINT")]
    Print,

    [EnumMember(Value = "MAIL")]
    Mail
}
