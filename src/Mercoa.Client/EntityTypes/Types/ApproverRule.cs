using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record ApproverRule
{
    [JsonPropertyName("numApprovers")]
    public required int NumApprovers { get; set; }

    [JsonPropertyName("identifierList")]
    public required object IdentifierList { get; set; }
}
