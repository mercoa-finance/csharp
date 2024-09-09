using Mercoa.Client;

#nullable enable

namespace Mercoa.Client.Entity;

public record FindPayorCounterpartiesRequest
{
    /// <summary>
    /// Filter by counterparty name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Filter by network type. By default, only ENTITY counterparties are returned.
    /// </summary>
    public IEnumerable<CounterpartyNetworkType> NetworkType { get; set; } =
        new List<CounterpartyNetworkType>();

    /// <summary>
    /// If true, will include counterparty payment methods as part of the response
    /// </summary>
    public bool? PaymentMethods { get; set; }

    /// <summary>
    /// If true, will include counterparty invoice metrics as part of the response
    /// </summary>
    public bool? InvoiceMetrics { get; set; }

    /// <summary>
    /// Filter by counterparty ids (Foreign ID is supported)
    /// </summary>
    public IEnumerable<string> CounterpartyId { get; set; } = new List<string>();

    /// <summary>
    /// If true, will return simple key/value metadata for the counterparties.
    /// </summary>
    public bool? ReturnMetadata { get; set; }

    /// <summary>
    /// Number of counterparties to return. Limit can range between 1 and 100, and the default is 10.
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// The ID of the counterparties to start after. If not provided, the first page of counterparties will be returned.
    /// </summary>
    public string? StartingAfter { get; set; }
}
