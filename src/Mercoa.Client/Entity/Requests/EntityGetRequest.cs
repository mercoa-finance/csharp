namespace Mercoa.Client.Entity;

public record EntityGetRequest
{
    /// <summary>
    /// Return simple key/value metadata for the specified keys for the entities. For more complex metadata, use the Metadata API.
    /// </summary>
    public IEnumerable<string> ReturnMetadata { get; set; } = new List<string>();
}
