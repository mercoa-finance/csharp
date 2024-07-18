namespace Mercoa.Client.Entity.User;

public record EntityFindEntityRequest
{
    /// <summary>
    /// ID used to identify user in your system
    /// </summary>
    public string? ForeignId { get; init; }

    /// <summary>
    /// Filter users by role. If multiple roles are provided, users with any of the roles will be returned.
    /// </summary>
    public string? Role { get; init; }

    /// <summary>
    /// Filter users by name. Partial matches are supported.
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Filter users by email. Partial matches are supported.
    /// </summary>
    public string? Email { get; init; }

    /// <summary>
    /// Number of entities to return. Limit can range between 1 and 100, and the default is 10.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The ID of the user to start after. If not provided, the first page of entities will be returned.
    /// </summary>
    public string? StartingAfter { get; init; }
}
