using Mercoa.Client;

#nullable enable

namespace Mercoa.Client.Entity.User;

public record EntityGetNotificationsRequest
{
    /// <summary>
    /// Start date for notification created on date filter.
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// End date for notification created date filter.
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Direction to order notifications by. Defaults to asc.
    /// </summary>
    public OrderDirection? OrderDirection { get; set; }

    /// <summary>
    /// Number of invoices to return. Limit can range between 1 and 100, and the default is 10.
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// The ID of the notification to start after. If not provided, the first page of invoices will be returned.
    /// </summary>
    public string? StartingAfter { get; set; }

    /// <summary>
    /// The type of notification to filter by.
    /// </summary>
    public IEnumerable<NotificationType> NotificationType { get; set; } =
        new List<NotificationType>();

    /// <summary>
    /// The status of the notification to filter by.
    /// </summary>
    public NotificationStatus? Status { get; set; }
}
