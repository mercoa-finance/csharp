using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<EmailSenderProvider>))]
public enum EmailSenderProvider
{
    [EnumMember(Value = "none")]
    None,

    [EnumMember(Value = "sendgrid")]
    Sendgrid,

    [EnumMember(Value = "ses")]
    Ses,

    [EnumMember(Value = "resend")]
    Resend
}
