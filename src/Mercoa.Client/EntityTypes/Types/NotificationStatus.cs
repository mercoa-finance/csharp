using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<NotificationStatus>))]
public enum NotificationStatus
{
    [EnumMember(Value = "PENDING")]
    Pending,

    [EnumMember(Value = "SENT")]
    Sent,

    [EnumMember(Value = "READ")]
    Read,

    [EnumMember(Value = "FAILED")]
    Failed
}
