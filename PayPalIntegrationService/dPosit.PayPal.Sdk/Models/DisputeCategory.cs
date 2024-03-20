namespace dPosit.PayPal.Sdk.Models;

public enum DisputeCategory
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// The payer paid for an item that they did not receive.
    /// </summary>
    ItemNotReceived,
    /// <summary>
    /// The payer did not authorize the payment.
    /// </summary>
    UnauthorizedTransaction
}
