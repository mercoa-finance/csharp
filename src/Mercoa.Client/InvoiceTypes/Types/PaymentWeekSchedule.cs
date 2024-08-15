using System.Text.Json.Serialization;
using Mercoa.Client;
using Mercoa.Client.Core;
using OneOf;

#nullable enable

namespace Mercoa.Client;

public record PaymentWeekSchedule
{
    [JsonPropertyName("repeatOn")]
    public IEnumerable<DayOfWeek> RepeatOn { get; init; } = new List<DayOfWeek>();

    /// <summary>
    /// How often to repeat the payments. Defaults to 1. Must be greater than 0. For example, if repeatEvery is set to 2 and this is a daily payment, the payment will be made every other day. If repeatEvery is set to 3 and this is a weekly payment, the payment will be made every third week.
    /// </summary>
    [JsonPropertyName("repeatEvery")]
    public int? RepeatEvery { get; init; }

    /// <summary>
    /// When to end the payments, either a number of occurrences or a date. Defaults to never ending if not specified
    /// </summary>
    [JsonPropertyName("ends")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<int, DateOnly>>))]
    public OneOf<int, DateOnly>? Ends { get; init; }
}
