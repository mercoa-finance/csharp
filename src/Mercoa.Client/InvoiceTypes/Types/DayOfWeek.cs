using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<DayOfWeek>))]
public enum DayOfWeek
{
    [EnumMember(Value = "0")]
    Sunday,

    [EnumMember(Value = "1")]
    Monday,

    [EnumMember(Value = "2")]
    Tuesday,

    [EnumMember(Value = "3")]
    Wednesday,

    [EnumMember(Value = "4")]
    Thursday,

    [EnumMember(Value = "5")]
    Friday,

    [EnumMember(Value = "6")]
    Saturday
}
