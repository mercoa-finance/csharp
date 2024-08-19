using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<VendorNetwork>))]
public enum VendorNetwork
{
    [EnumMember(Value = "all")]
    All,

    [EnumMember(Value = "platform")]
    Platform,

    [EnumMember(Value = "entity")]
    Entity
}
