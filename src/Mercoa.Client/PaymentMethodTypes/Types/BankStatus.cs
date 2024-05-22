using System.Runtime.Serialization;

namespace Mercoa.Client;

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
