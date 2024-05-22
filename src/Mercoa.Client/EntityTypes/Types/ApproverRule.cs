using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class ApproverRule
{
    [JsonPropertyName("numApprovers")]
    public int NumApprovers { get; init; }

    [JsonPropertyName("identifierList")]
    public IdentifierList IdentifierList { get; init; }
}
