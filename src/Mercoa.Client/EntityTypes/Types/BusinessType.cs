using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum BusinessType
{
    [EnumMember(Value = "soleProprietorship")]
    SoleProprietorship,

    [EnumMember(Value = "unincorporatedAssociation")]
    UnincorporatedAssociation,

    [EnumMember(Value = "trust")]
    Trust,

    [EnumMember(Value = "publicCorporation")]
    PublicCorporation,

    [EnumMember(Value = "privateCorporation")]
    PrivateCorporation,

    [EnumMember(Value = "llc")]
    Llc,

    [EnumMember(Value = "partnership")]
    Partnership,

    [EnumMember(Value = "unincorporatedNonProfit")]
    UnincorporatedNonProfit,

    [EnumMember(Value = "incorporatedNonProfit")]
    IncorporatedNonProfit
}
