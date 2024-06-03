using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;
using Mercoa.Client.Entity;

#nullable enable

namespace Mercoa.Client.Entity;

[JsonConverter(typeof(StringEnumSerializer<SyncType>))]
public enum SyncType
{
    [EnumMember(Value = "none")]
    None,

    [EnumMember(Value = "push")]
    Push,

    [EnumMember(Value = "pull")]
    Pull,

    [EnumMember(Value = "both")]
    Both
}
