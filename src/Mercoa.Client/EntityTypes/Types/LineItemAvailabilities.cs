using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum LineItemAvailabilities
{
    [EnumMember(Value = "DISABLED")]
    Disabled,

    [EnumMember(Value = "OPTIONAL")]
    Optional,

    [EnumMember(Value = "REQUIRED")]
    Required
}
