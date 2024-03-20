namespace dPosit.PayPal.Sdk.Models;

public enum SellerProtectionStatus
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// Your PayPal balance remains intact if the customer claims that they did not receive an item or the account holder
    /// claims that they did not authorize the payment.
    /// </summary>
    Eligible,
    /// <summary>
    /// Your PayPal balance remains intact if the customer claims that they did not receive an item.
    /// </summary>
    PartiallyEligible,
    /// <summary>
    /// This transaction is not eligible for seller protection.
    /// </summary>
    NotEligible
}
