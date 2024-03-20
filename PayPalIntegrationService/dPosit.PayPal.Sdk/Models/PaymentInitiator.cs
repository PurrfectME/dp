namespace dPosit.PayPal.Sdk.Models;

public enum PaymentInitiator
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// Payment is initiated with the active engagement of the customer. e.g. a customer checking out on a merchant website.
    /// </summary>
    Customer,
    /// <summary>
    /// Payment is initiated by merchant on behalf of the customer without the active engagement of customer. e.g. a merchant
    /// charging the monthly payment of a subscription to the customer.
    /// </summary>
    Merchant
}
