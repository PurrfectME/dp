namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class RefundStatusDetails
{
    /// <summary>
    /// The reason why the refund has the <c>PENDING</c> or <c>FAILED</c> status.
    /// </summary>
    /// <value>
    /// "ECHECK" - the customer's account is funded through an eCheck, which has not yet cleared.
    /// </value>
    public string Reason { get; set; }
}
