using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<AccountType>))]
public enum AccountType
{
    [EnumMember(Value = "business")]
    Business,

    [EnumMember(Value = "individual")]
    Individual
}
