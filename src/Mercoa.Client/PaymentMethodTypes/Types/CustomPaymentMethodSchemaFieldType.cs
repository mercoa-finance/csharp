using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<CustomPaymentMethodSchemaFieldType>))]
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
    Address,

    [EnumMember(Value = "usBankRoutingNumber")]
    UsBankRoutingNumber,

    [EnumMember(Value = "usBankAccountNumber")]
    UsBankAccountNumber
}
