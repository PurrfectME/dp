namespace dPosit.PayPal.Sdk.Models;

public enum PaymentMethod
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// Accepts any type of payment.
    /// </summary>
    Unrestricted,
    /// <summary>
    /// Accepts only immediate payment. Ensures that at the time of capture, the payment does not have the `pending` status.
    /// </summary>
    /// <example>
    /// Credit card, PayPal balance, or instant ACH.
    /// </example>
    ImmediatePaymentRequired
}
