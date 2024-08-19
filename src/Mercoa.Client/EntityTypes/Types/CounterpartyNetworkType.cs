using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<CounterpartyNetworkType>))]
public enum CounterpartyNetworkType
{
    [EnumMember(Value = "ENTITY")]
    Entity,

    [EnumMember(Value = "NETWORK")]
    Network
}
