using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<TransactionStatus>))]
public enum TransactionStatus
{
    [EnumMember(Value = "CREATED")]
    Created,

    [EnumMember(Value = "PENDING")]
    Pending,

    [EnumMember(Value = "COMPLETED")]
    Completed,

    [EnumMember(Value = "FAILED")]
    Failed,

    [EnumMember(Value = "REVERSED")]
    Reversed,

    [EnumMember(Value = "QUEUED")]
    Queued,

    [EnumMember(Value = "CANCELED")]
    Canceled
}
