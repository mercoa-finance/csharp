using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client.Entity;

public class CompleteMicroDepositsRequest
{
    /// <summary>
    /// The amounts of the micro deposits in cents
    /// </summary>
    [JsonPropertyName("amounts")]
    public IEnumerable<int> Amounts { get; init; }
}
