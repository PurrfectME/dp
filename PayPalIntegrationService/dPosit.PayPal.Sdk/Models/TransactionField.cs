namespace dPosit.PayPal.Sdk.Models;

public enum TransactionField
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// The transaction information. Includes the ID of the PayPal account of the payee, the PayPal-generated
    /// transaction ID, the PayPal-generated base ID, the PayPal reference ID type, the transaction event code, the date and time when
    /// the transaction was initiated and was last updated, the transaction amounts including the PayPal fee, any discounts, insurance,
    /// the transaction status, and other information about the transaction.
    /// </summary>
    TransactionInfo,
    /// <summary>
    /// The payer information. Includes the PayPal customer account ID and the payer's email address, primary phone number,
    /// name, country code, address, and whether the payer is verified or unverified.
    /// </summary>
    PayerInfo,
    /// <summary>
    /// The shipping information. Includes the recipient's name, the shipping method for this order, the shipping address
    /// for this order, and the secondary address associated with this order.
    /// </summary>
    ShippingInfo,
    /// <summary>
    /// The auction information. Includes the name of the auction site, the auction site URL, the ID of the customer who
    /// makes the purchase in the auction, and the date and time when the auction closes.
    /// </summary>
    AuctionInfo,
    /// <summary>
    /// The cart information. Includes an array of item details, whether the item amount or the shipping amount already
    /// includes tax, and the ID of the invoice for PayPal-generated invoices.
    /// </summary>
    CartInfo,
    /// <summary>
    /// An array of incentive detail objects. Each object includes the incentive, such as a special offer or coupon,
    /// the incentive amount, and the incentive program code that identifies a merchant loyalty or incentive program.
    /// </summary>
    IncentiveInfo,
    /// <summary>
    /// The store information. Includes the ID of the merchant store and the terminal ID for the checkout stand in the
    /// merchant store.
    /// </summary>
    StoreInfo,
    /// <summary>
    /// Include all fields.
    /// </summary>
    All
}
