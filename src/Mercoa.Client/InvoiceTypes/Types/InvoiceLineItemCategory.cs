using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<InvoiceLineItemCategory>))]
public enum InvoiceLineItemCategory
{
    [EnumMember(Value = "EXPENSE")]
    Expense,

    [EnumMember(Value = "REVENUE")]
    Revenue,

    [EnumMember(Value = "TAX")]
    Tax,

    [EnumMember(Value = "SHIPPING")]
    Shipping,

    [EnumMember(Value = "DISCOUNT")]
    Discount,

    [EnumMember(Value = "OTHER")]
    Other
}
