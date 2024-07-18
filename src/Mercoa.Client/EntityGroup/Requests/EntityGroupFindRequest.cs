namespace Mercoa.Client.EntityGroup;

public record EntityGroupFindRequest
{
    /// <summary>
    /// The maximum number of results to return. Defaults to 1. Max is 10.
    /// </summary>
    public int? Limit { get; init; }

    public string? StartingAfter { get; init; }
}
