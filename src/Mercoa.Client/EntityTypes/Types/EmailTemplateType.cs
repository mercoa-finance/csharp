using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<EmailTemplateType>))]
public enum EmailTemplateType
{
    [EnumMember(Value = "PAYMENT")]
    Payment,

    [EnumMember(Value = "DISBURSEMENT")]
    Disbursement
}
