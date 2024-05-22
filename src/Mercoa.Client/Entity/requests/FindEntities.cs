using Mercoa.Client;

namespace Mercoa.Client.Entity;

public class FindEntities
{
    /// <summary>
    /// If true, will include entity payment methods as part of the response
    /// </summary>
    public bool? PaymentMethods { get; init; }

    /// <summary>
    /// If true, only entities with a direct relationship to the requesting organization will be returned. If false or not provided, all entities will be returned.
    /// </summary>
    public bool? IsCustomer { get; init; }

    /// <summary>
    /// ID used to identify this entity in your system
    /// </summary>
    public string? ForeignId { get; init; }

    public EntityStatus? Status { get; init; }

    /// <summary>
    /// If true, entities that are marked as payees will be returned.
    /// If false or not provided, entities that are marked as payees will not be returned.
    /// </summary>
    public bool? IsPayee { get; init; }

    /// <summary>
    /// If true or not provided, entities that are marked as payors will be returned.
    /// If false, entities that are marked as payors will not be returned.
    /// </summary>
    public bool? IsPayor { get; init; }

    /// <summary>
    /// Filter entities by name. Partial matches are supported.
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Number of entities to return. Limit can range between 1 and 100, and the default is 10.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The ID of the entity to start after. If not provided, the first page of entities will be returned.
    /// </summary>
    public string? StartingAfter { get; init; }
}
