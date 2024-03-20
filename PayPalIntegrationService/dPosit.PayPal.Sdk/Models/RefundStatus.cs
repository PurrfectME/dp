namespace dPosit.PayPal.Sdk.Models;

public enum RefundStatus
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// The refund was cancelled.
    /// </summary>
    Cancelled,
    /// <summary>
    /// The refund is pending. For more information, see status_details.reason.
    /// </summary>
    Pending,
    /// <summary>
    /// The funds for this transaction were debited to the customer's account.
    /// </summary>
    Completed
}
