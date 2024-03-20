namespace dPosit.PayPal.Sdk.Models;

public enum UserCheckoutAction
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// After you redirect the customer to the PayPal payment page, a <b>Continue</b> button appears. Use this option when the
    /// final amount is not known when the checkout flow is initiated and you want to redirect the customer to the merchant page without
    /// processing the payment
    /// </summary>
    Continue,
    /// <summary>
    /// After you redirect the customer to the PayPal payment page, a <b>Pay Now</b> button appears. Use this option when the
    /// final amount is known when the checkout is initiated and you want to process the payment immediately when the customer clicks
    /// <b>Pay Now</b>.
    /// </summary>
    PayNow
}
