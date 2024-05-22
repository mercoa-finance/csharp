using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum CardBrand
{
    [EnumMember(Value = "AmericanExpress")]
    AmericanExpress,

    [EnumMember(Value = "Discover")]
    Discover,

    [EnumMember(Value = "Mastercard")]
    Mastercard,

    [EnumMember(Value = "Visa")]
    Visa
}
