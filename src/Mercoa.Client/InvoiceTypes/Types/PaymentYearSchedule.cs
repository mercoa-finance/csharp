using System.Text.Json.Serialization;
using Mercoa.Client.Core;
using OneOf;

#nullable enable

namespace Mercoa.Client;

public record PaymentYearSchedule
{
    /// <summary>
    /// Day of the month to repeat on (1-31).
    /// </summary>
    [JsonPropertyName("repeatOnDay")]
    public required int RepeatOnDay { get; set; }

    /// <summary>
    /// Month to repeat on (1-12).
    /// </summary>
    [JsonPropertyName("repeatOnMonth")]
    public required int RepeatOnMonth { get; set; }

    /// <summary>
    /// How often to repeat the payments. Defaults to 1. Must be greater than 0. For example, if repeatEvery is set to 2 and this is a daily payment, the payment will be made every other day. If repeatEvery is set to 3 and this is a weekly payment, the payment will be made every third week.
    /// </summary>
    [JsonPropertyName("repeatEvery")]
    public int? RepeatEvery { get; set; }

    /// <summary>
    /// When to end the payments, either a number of occurrences or a date. Defaults to never ending if not specified
    /// </summary>
    [JsonPropertyName("ends")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<int, DateOnly>>))]
    public OneOf<int, DateOnly>? Ends { get; set; }
}
