using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum PaymentRailMarkupType
{
    [EnumMember(Value = "flat")]
    Flat,

    [EnumMember(Value = "percent")]
    Percent
}
