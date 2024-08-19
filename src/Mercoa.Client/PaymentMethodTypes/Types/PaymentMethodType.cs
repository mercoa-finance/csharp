using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<PaymentMethodType>))]
public enum PaymentMethodType
{
    [EnumMember(Value = "custom")]
    Custom,

    [EnumMember(Value = "check")]
    Check,

    [EnumMember(Value = "bankAccount")]
    BankAccount,

    [EnumMember(Value = "na")]
    Na,

    [EnumMember(Value = "card")]
    Card,

    [EnumMember(Value = "bnpl")]
    Bnpl,

    [EnumMember(Value = "virtualCard")]
    VirtualCard,

    [EnumMember(Value = "offPlatform")]
    OffPlatform,

    [EnumMember(Value = "utility")]
    Utility
}
