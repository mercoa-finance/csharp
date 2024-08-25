namespace Mercoa.Client.EntityGroup;

public record EntityGroupGetRequest
{
    /// <summary>
    /// If true, will return simple key/value metadata for entities in the group. For more complex metadata, use the Metadata API.
    /// </summary>
    public bool? EntityMetadata { get; set; }
}
