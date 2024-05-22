using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum BankDeliveryMethod
{
    [EnumMember(Value = "ACH_STANDARD")]
    AchStandard,

    [EnumMember(Value = "ACH_SAME_DAY")]
    AchSameDay
}
