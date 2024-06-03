using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<BusinessType>))]
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
