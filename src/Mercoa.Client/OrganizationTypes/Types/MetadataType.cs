using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<MetadataType>))]
public enum MetadataType
{
    [EnumMember(Value = "STRING")]
    String,

    [EnumMember(Value = "NUMBER")]
    Number,

    [EnumMember(Value = "DATE")]
    Date,

    [EnumMember(Value = "BOOLEAN")]
    Boolean,

    [EnumMember(Value = "KEY_VALUE")]
    KeyValue
}
