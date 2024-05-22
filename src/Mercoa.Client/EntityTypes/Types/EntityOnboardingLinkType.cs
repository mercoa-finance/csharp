using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum EntityOnboardingLinkType
{
    [EnumMember(Value = "PAYEE")]
    Payee,

    [EnumMember(Value = "PAYOR")]
    Payor
}
