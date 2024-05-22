using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum VendorNetwork
{
    [EnumMember(Value = "all")]
    All,

    [EnumMember(Value = "platform")]
    Platform,

    [EnumMember(Value = "entity")]
    Entity
}
