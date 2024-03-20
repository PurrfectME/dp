using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class SellerProtection
{
    /// <summary>
    /// An array of conditions that are covered for the transaction.
    /// </summary>
    /// <value>
    /// "ITEM_NOT_RECEIVED" - the payer paid for an item that they did not receive.<br/>
    /// "UNAUTHORIZED_TRANSACTION" - the payer did not authorize the payment.
    /// </value>
    [JsonPropertyName("dispute_categories")]
    public string[] DisputeCategories { get; set; }

    /// <summary>
    /// Indicates whether the transaction is eligible for seller protection. For information, see PayPal Seller Protection for Merchants.
    /// </summary>
    /// <value>
    /// "ELIGIBLE" - your PayPal balance remains intact if the customer claims that they did not receive an item or the account holder
    /// claims that they did not authorize the payment.<br/>
    /// "PARTIALLY_ELIGIBLE" - your PayPal balance remains intact if the customer claims that they did not receive an item.<br/>
    /// "NOT_ELIGIBLE" - this transaction is not eligible for seller protection.
    /// </value>
    [JsonPropertyName("status")]
    public string Status { get; set; }
}
