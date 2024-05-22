using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum BankType
{
    [EnumMember(Value = "CHECKING")]
    Checking,

    [EnumMember(Value = "SAVINGS")]
    Savings,

    [EnumMember(Value = "UNKNOWN")]
    Unknown
}
