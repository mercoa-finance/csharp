using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum AccountType
{
    [EnumMember(Value = "business")]
    Business,

    [EnumMember(Value = "individual")]
    Individual
}
