using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum CustomPaymentMethodSchemaFieldType
{
    [EnumMember(Value = "text")]
    Text,

    [EnumMember(Value = "number")]
    Number,

    [EnumMember(Value = "select")]
    Select,

    [EnumMember(Value = "date")]
    Date,

    [EnumMember(Value = "phone")]
    Phone,

    [EnumMember(Value = "email")]
    Email,

    [EnumMember(Value = "url")]
    Url,

    [EnumMember(Value = "address")]
    Address
}
