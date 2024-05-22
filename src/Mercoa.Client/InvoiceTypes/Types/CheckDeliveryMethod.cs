using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum CheckDeliveryMethod
{
    [EnumMember(Value = "PRINT")]
    Print,

    [EnumMember(Value = "MAIL")]
    Mail
}
