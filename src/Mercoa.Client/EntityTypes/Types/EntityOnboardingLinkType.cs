using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<EntityOnboardingLinkType>))]
public enum EntityOnboardingLinkType
{
    [EnumMember(Value = "PAYEE")]
    Payee,

    [EnumMember(Value = "PAYOR")]
    Payor
}
