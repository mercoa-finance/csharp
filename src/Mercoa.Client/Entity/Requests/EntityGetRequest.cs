namespace Mercoa.Client.Entity;

public record EntityGetRequest
{
    /// <summary>
    /// If true, will return simple key/value metadata for the entity. For more complex metadata, use the Metadata API.
    /// </summary>
    public bool? Metadata { get; set; }
}
