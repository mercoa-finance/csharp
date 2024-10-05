namespace Mercoa.Client.EntityGroup;

public record EntityGroupGetRequest
{
    /// <summary>
    /// Return simple key/value metadata for the specified keys for the entities in the group. For more complex metadata, use the Metadata API.
    /// </summary>
    public IEnumerable<string> ReturnEntityMetadata { get; set; } = new List<string>();
}
