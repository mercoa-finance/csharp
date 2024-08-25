using System.Text.Json.Serialization;
using Mercoa.Client.Core;
using OneOf;

#nullable enable

namespace Mercoa.Client;

public record PaymentMonthSchedule
{
    /// <summary>
    /// Offset from the start or end of the month to repeat on (0-30). Defaults to 0.
    /// </summary>
    [JsonPropertyName("dayOffset")]
    public required int DayOffset { get; set; }

    /// <summary>
    /// Type of offset. If start, will offset from the start of the month (so 10 with an offset of start will be on the 10th of the month). If end, will offset from the end of the month (so 10 with an offset of end will be the 20th).
    /// </summary>
    [JsonPropertyName("offsetType")]
    public PaymentMonthRepeatType? OffsetType { get; set; }

    /// <summary>
    /// How often to repeat the payments. Defaults to 1. Must be greater than 0. For example, if repeatEvery is set to 2 and this is a daily payment, the payment will be made every other day. If repeatEvery is set to 3 and this is a weekly payment, the payment will be made every third week.
    /// </summary>
    [JsonPropertyName("repeatEvery")]
    public int? RepeatEvery { get; set; }

    /// <summary>
    /// When to end the payments, either a number of occurrences or a date. Defaults to never ending if not specified
    /// </summary>
    [JsonPropertyName("ends")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<int, DateTime>>))]
    public OneOf<int, DateTime>? Ends { get; set; }
}
