using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<NotificationType>))]
public enum NotificationType
{
    [EnumMember(Value = "INVOICE_APPROVAL_NEEDED")]
    InvoiceApprovalNeeded,

    [EnumMember(Value = "INVOICE_APPROVED")]
    InvoiceApproved,

    [EnumMember(Value = "INVOICE_REJECTED")]
    InvoiceRejected,

    [EnumMember(Value = "INVOICE_SCHEDULED")]
    InvoiceScheduled,

    [EnumMember(Value = "INVOICE_PENDING")]
    InvoicePending,

    [EnumMember(Value = "INVOICE_PAID")]
    InvoicePaid,

    [EnumMember(Value = "INVOICE_CANCELED")]
    InvoiceCanceled,

    [EnumMember(Value = "INVOICE_CREATED")]
    InvoiceCreated,

    [EnumMember(Value = "INVOICE_EMAILED")]
    InvoiceEmailed,

    [EnumMember(Value = "INVOICE_FAILED")]
    InvoiceFailed,

    [EnumMember(Value = "COUNTERPARTY_ONBOARDING_COMPLETED")]
    CounterpartyOnboardingCompleted
}
