using System.Runtime.Serialization;

namespace Mercoa.Client;

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
