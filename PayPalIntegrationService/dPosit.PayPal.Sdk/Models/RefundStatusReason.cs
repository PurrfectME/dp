namespace dPosit.PayPal.Sdk.Models;

public enum RefundStatusReason
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// The customer's account is funded through an eCheck, which has not yet cleared.
    /// </summary>
    Echeck
}
