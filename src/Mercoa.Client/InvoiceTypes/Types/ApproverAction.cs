using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum ApproverAction
{
    [EnumMember(Value = "NONE")]
    None,

    [EnumMember(Value = "APPROVE")]
    Approve,

    [EnumMember(Value = "REJECT")]
    Reject
}
