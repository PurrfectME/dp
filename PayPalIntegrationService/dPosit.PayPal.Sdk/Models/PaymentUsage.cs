namespace dPosit.PayPal.Sdk.Models;

public enum PaymentUsage
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// Indicates the Initial/First payment with a payment_source that is intended to be stored upon successful processing of the payment.
    /// </summary>
    First,
    /// <summary>
    /// Indicates a payment using a stored payment_source which has been successfully used previously for a payment.
    /// </summary>
    Subsequent,
    /// <summary>
    /// Indicates that PayPal will derive the value of `FIRST` or `SUBSEQUENT` based on data available to PayPal.
    /// </summary>
    Derived
}
