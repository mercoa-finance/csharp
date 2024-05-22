using System.Runtime.Serialization;

namespace Mercoa.Client.Entity;

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
