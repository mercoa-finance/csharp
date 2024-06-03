using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<EntityStatus>))]
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
