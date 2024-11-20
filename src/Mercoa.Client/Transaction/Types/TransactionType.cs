using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<TransactionType>))]
public enum TransactionType
{
    [EnumMember(Value = "bankAccountToBankAccount")]
    BankAccountToBankAccount,

    [EnumMember(Value = "bankAccountToMailedCheck")]
    BankAccountToMailedCheck,

    [EnumMember(Value = "custom")]
    Custom
}
