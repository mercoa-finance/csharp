using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<CardBrand>))]
public enum CardBrand
{
    [EnumMember(Value = "AmericanExpress")]
    AmericanExpress,

    [EnumMember(Value = "Discover")]
    Discover,

    [EnumMember(Value = "Mastercard")]
    Mastercard,

    [EnumMember(Value = "Visa")]
    Visa
}
