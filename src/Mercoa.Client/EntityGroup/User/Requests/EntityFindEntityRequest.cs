namespace Mercoa.Client.EntityGroup.User;

public record EntityFindEntityRequest
{
    /// <summary>
    /// ID used to identify user in your system
    /// </summary>
    public IEnumerable<string> ForeignId { get; set; } = new List<string>();

    /// <summary>
    /// Filter users by role. If multiple roles are provided, users with any of the roles will be returned.
    /// </summary>
    public IEnumerable<string> Role { get; set; } = new List<string>();

    /// <summary>
    /// Filter users by name. Partial matches are supported.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Filter users by email. Partial matches are supported.
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Number of entities to return. Limit can range between 1 and 100, and the default is 10.
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// The ID of the user to start after. If not provided, the first page of entities will be returned.
    /// </summary>
    public string? StartingAfter { get; set; }
}
