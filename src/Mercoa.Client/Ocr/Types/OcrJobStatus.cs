using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum OcrJobStatus
{
    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "success")]
    Success,

    [EnumMember(Value = "failed")]
    Failed
}
