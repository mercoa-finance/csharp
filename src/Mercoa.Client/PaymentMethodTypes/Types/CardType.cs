using System.Runtime.Serialization;

namespace Mercoa.Client;

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
