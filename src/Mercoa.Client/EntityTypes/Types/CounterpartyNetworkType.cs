using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum CounterpartyNetworkType
{
    [EnumMember(Value = "ENTITY")]
    Entity,

    [EnumMember(Value = "NETWORK")]
    Network
}
