using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<ApproverAction>))]
public enum ApproverAction
{
    [EnumMember(Value = "NONE")]
    None,

    [EnumMember(Value = "APPROVE")]
    Approve,

    [EnumMember(Value = "REJECT")]
    Reject
}
