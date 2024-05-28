using System.Text.Json.Serialization;

namespace Mercoa.Client.Entity;

public class CompleteMicroDepositsRequest
{
    /// <summary>
    /// The amounts of the micro deposits in cents
    /// </summary>
    [JsonPropertyName("amounts")]
    public List<int> Amounts { get; init; }
}
