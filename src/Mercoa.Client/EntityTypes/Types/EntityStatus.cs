using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum EntityStatus
{
    [EnumMember(Value = "unverified")]
    Unverified,

    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "resubmit")]
    Resubmit,

    [EnumMember(Value = "review")]
    Review,

    [EnumMember(Value = "verified")]
    Verified,

    [EnumMember(Value = "failed")]
    Failed
}
