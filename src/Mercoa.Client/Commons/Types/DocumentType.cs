using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<DocumentType>))]
public enum DocumentType
{
    [EnumMember(Value = "INVOICE")]
    Invoice,

    [EnumMember(Value = "TEN_NINETY_NINE")]
    TenNinetyNine,

    [EnumMember(Value = "W9")]
    W9,

    [EnumMember(Value = "CHECK")]
    Check
}
