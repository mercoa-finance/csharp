using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record BankAccountCheckOptions
{
    /// <summary>
    /// If true, will allow the user to print checks from this bank account
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// If provided, will start the check number sequence at the provided number. If not provided, will start at 5000.
    /// </summary>
    [JsonPropertyName("initialCheckNumber")]
    public int? InitialCheckNumber { get; set; }

    /// <summary>
    /// If provided, will print a check with the provided routing number instead of the one from the bank account
    /// </summary>
    [JsonPropertyName("routingNumberOverride")]
    public string? RoutingNumberOverride { get; set; }

    /// <summary>
    /// If provided, will print a check with the provided account number instead of the one from the bank account
    /// </summary>
    [JsonPropertyName("accountNumberOverride")]
    public string? AccountNumberOverride { get; set; }

    /// <summary>
    /// Name of the person who's signature will be printed on the check.
    /// </summary>
    [JsonPropertyName("signatoryName")]
    public required string SignatoryName { get; set; }

    /// <summary>
    /// Base64 encoded image of the signature. If not provided, will use the signatoryName to generate a signature. Mercoa will automatically grayscale, resize, and convert the image to a PNG the image to fit on the check.
    /// </summary>
    [JsonPropertyName("signatureImage")]
    public string? SignatureImage { get; set; }

    /// <summary>
    /// If true, will print checks with the provided signatureImage. If false, will print checks with a generated signature from the signatoryName. If this parameter is not set the default behavior is to use the signatureImage if provided.
    /// </summary>
    [JsonPropertyName("useSignatureImage")]
    public bool? UseSignatureImage { get; set; }
}
