using Mercoa.Client;

namespace Mercoa.Client.Entity.User;

public class EntityGetNotificationsRequest
{
    /// <summary>
    /// Start date for notification created on date filter.
    /// </summary>
    public DateTime? StartDate { get; init; }

    /// <summary>
    /// End date for notification created date filter.
    /// </summary>
    public DateTime? EndDate { get; init; }

    /// <summary>
    /// Direction to order notifications by. Defaults to asc.
    /// </summary>
    public OrderDirection? OrderDirection { get; init; }

    /// <summary>
    /// Number of invoices to return. Limit can range between 1 and 100, and the default is 10.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The ID of the notification to start after. If not provided, the first page of invoices will be returned.
    /// </summary>
    public string? StartingAfter { get; init; }

    /// <summary>
    /// The type of notification to filter by.
    /// </summary>
    public NotificationType? NotificationType { get; init; }
}
