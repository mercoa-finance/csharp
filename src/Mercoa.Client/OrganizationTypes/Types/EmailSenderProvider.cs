using System.Runtime.Serialization;

namespace Mercoa.Client;

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
