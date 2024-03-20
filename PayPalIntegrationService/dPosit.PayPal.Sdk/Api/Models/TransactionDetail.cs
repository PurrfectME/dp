using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class TransactionDetail
{
    /// <summary>
    /// The auction information.
    /// </summary>
    [JsonPropertyName("auction_info")]
    public AuctionInfo AuctionInfo { get; set; }

    /// <summary>
    /// The cart information.
    /// </summary>
    [JsonPropertyName("cart_info")]
    public CartInfo CartInfo { get; set; }

    /// <summary>
    /// The incentive information.
    /// </summary>
    [JsonPropertyName("incentive_info")]
    public IncentiveInfo IncentiveInfo { get; set; }
    
    /// <summary>
    /// The payer information.
    /// </summary>
    [JsonPropertyName("payer_info")]
    public PayerInfo PayerInfo { get; set; }

    /// <summary>
    /// The shipping information.
    /// </summary>
    [JsonPropertyName("shipping_info")]
    public ShippingInfo ShippingInfo { get; set; }

    /// <summary>
    /// The store information.
    /// </summary>
    [JsonPropertyName("store_info")]
    public StoreInfo StoreInfo { get; set; }

    /// <summary>
    /// The transaction information.
    /// </summary>
    [JsonPropertyName("transaction_info")]
    public TransactionInfo TransactionInfo { get; set; }
}
