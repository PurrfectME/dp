namespace dPosit.PayPal.Sdk.Models;

public enum ItemCategory
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// Goods that are stored, delivered, and used in their electronic format.
    /// </summary>
    /// <remarks>
    /// This value is not currently supported for API callers that leverage the PayPal for Commerce Platform product.
    /// </remarks>
    DigitalGoods,
    /// <summary>
    /// A tangible item that can be shipped with proof of delivery.
    /// </summary>
    PhysicalGoods,
    /// <summary>
    /// A contribution or gift for which no good or service is exchanged, usually to a not for profit organization.
    /// </summary>
    Donation
}
