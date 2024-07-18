using Mercoa.Client;

#nullable enable

namespace Mercoa.Client.Entity;

public record FindPayorCounterpartiesRequest
{
    /// <summary>
    /// Filter by counterparty name
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Filter by network type. By default, only ENTITY counterparties are returned.
    /// </summary>
    public CounterpartyNetworkType? NetworkType { get; init; }

    /// <summary>
    /// If true, will include counterparty payment methods as part of the response
    /// </summary>
    public bool? PaymentMethods { get; init; }

    /// <summary>
    /// If true, will include counterparty invoice metrics as part of the response
    /// </summary>
    public bool? InvoiceMetrics { get; init; }

    /// <summary>
    /// If true, will include counterparty logo as part of the response
    /// </summary>
    public bool? Logo { get; init; }

    /// <summary>
    /// Filter by counterparty ids
    /// </summary>
    public string? CounterpartyId { get; init; }

    /// <summary>
    /// Number of counterparties to return. Limit can range between 1 and 100, and the default is 10.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The ID of the counterparties to start after. If not provided, the first page of counterparties will be returned.
    /// </summary>
    public string? StartingAfter { get; init; }
}
