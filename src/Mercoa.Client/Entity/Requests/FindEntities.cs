using Mercoa.Client;

#nullable enable

namespace Mercoa.Client.Entity;

public record FindEntities
{
    /// <summary>
    /// If true, will include entity payment methods as part of the response
    /// </summary>
    public bool? PaymentMethods { get; set; }

    /// <summary>
    /// If true, only entities with a direct relationship to the requesting organization will be returned. If false or not provided, all entities will be returned.
    /// </summary>
    public bool? IsCustomer { get; set; }

    /// <summary>
    /// ID used to identify this entity in your system
    /// </summary>
    public IEnumerable<string> ForeignId { get; set; } = new List<string>();

    public IEnumerable<EntityStatus> Status { get; set; } = new List<EntityStatus>();

    /// <summary>
    /// If true, entities that are marked as payees will be returned.
    /// If false or not provided, entities that are marked as payees will not be returned.
    /// </summary>
    public bool? IsPayee { get; set; }

    /// <summary>
    /// If true or not provided, entities that are marked as payors will be returned.
    /// If false, entities that are marked as payors will not be returned.
    /// </summary>
    public bool? IsPayor { get; set; }

    /// <summary>
    /// Use search instead. Deprecated. Filter entities by name. Partial matches are supported.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Find entities by name, email, or emailTo. Partial matches are supported.
    /// </summary>
    public string? Search { get; set; }

    /// <summary>
    /// Filter entities by simple key/value metadata. Each filter will be applied as an AND condition. Duplicate keys will be ignored.
    /// </summary>
    public MetadataFilter? Metadata { get; set; }

    /// <summary>
    /// Return simple key/value metadata for the specified keys for the entities. For more complex metadata, use the Metadata API.
    /// </summary>
    public IEnumerable<string> ReturnMetadata { get; set; } = new List<string>();

    /// <summary>
    /// Number of entities to return. Limit can range between 1 and 100, and the default is 10.
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// The ID of the entity to start after. If not provided, the first page of entities will be returned.
    /// </summary>
    public string? StartingAfter { get; set; }
}
