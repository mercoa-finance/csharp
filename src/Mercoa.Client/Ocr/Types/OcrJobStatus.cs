using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<OcrJobStatus>))]
public enum OcrJobStatus
{
    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "success")]
    Success,

    [EnumMember(Value = "failed")]
    Failed
}
