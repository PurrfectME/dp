namespace dPosit.PayPal.Sdk.Models;

public enum ShippingType
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// The payer intends to receive the items at a specified address.
    /// </summary>
    Shipping,
    /// <summary>
    /// The payer intends to pick up the items from the payee in person.
    /// </summary>
    Pickup
}
