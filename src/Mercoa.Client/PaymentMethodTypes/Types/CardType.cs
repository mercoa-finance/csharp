using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<CardType>))]
public enum CardType
{
    [EnumMember(Value = "credit")]
    Credit,

    [EnumMember(Value = "debit")]
    Debit,

    [EnumMember(Value = "prepaid")]
    Prepaid,

    [EnumMember(Value = "unknown")]
    Unknown
}
