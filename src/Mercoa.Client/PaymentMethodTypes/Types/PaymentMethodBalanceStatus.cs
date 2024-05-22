using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum PaymentMethodBalanceStatus
{
    [EnumMember(Value = "AVAILABLE")]
    Available,

    [EnumMember(Value = "UNAVAILABLE")]
    Unavailable,

    [EnumMember(Value = "ERROR")]
    Error
}
