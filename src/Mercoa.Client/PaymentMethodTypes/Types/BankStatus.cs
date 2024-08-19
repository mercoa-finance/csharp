using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<BankStatus>))]
public enum BankStatus
{
    [EnumMember(Value = "NEW")]
    New,

    [EnumMember(Value = "VERIFIED")]
    Verified,

    [EnumMember(Value = "VERIFICATION_FAILED")]
    VerificationFailed,

    [EnumMember(Value = "PENDING")]
    Pending,

    [EnumMember(Value = "ERRORED")]
    Errored
}
