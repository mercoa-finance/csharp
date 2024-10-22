using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<BankDeliveryMethod>))]
public enum BankDeliveryMethod
{
    [EnumMember(Value = "ACH_STANDARD")]
    AchStandard,

    [EnumMember(Value = "ACH_SAME_DAY")]
    AchSameDay,

    [EnumMember(Value = "ACH_ACCELERATED")]
    AchAccelerated
}
