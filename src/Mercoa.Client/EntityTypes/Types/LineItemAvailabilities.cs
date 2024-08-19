using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<LineItemAvailabilities>))]
public enum LineItemAvailabilities
{
    [EnumMember(Value = "DISABLED")]
    Disabled,

    [EnumMember(Value = "OPTIONAL")]
    Optional,

    [EnumMember(Value = "REQUIRED")]
    Required
}
