using System.Runtime.Serialization;

namespace Mercoa.Client;

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
    OffPlatform
}
