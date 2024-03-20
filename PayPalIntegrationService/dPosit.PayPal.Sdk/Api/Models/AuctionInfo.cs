using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class AuctionInfo
{
    /// <summary>
    /// The ID of the buyer who makes the purchase in the auction. This ID might be different from the payer ID provided for the payment.
    /// </summary>
    [JsonPropertyName("auction_buyer_id")]
    public string AuctionBuyerId { get; set; }

    /// <summary>
    /// The date and time when the auction closes, in Internet date and time format. Seconds are required while
    /// fractional seconds are optional.
    /// </summary>
    [JsonPropertyName("auction_closing_date")]
    public string AuctionClosingDate { get; set; }

    /// <summary>
    /// The auction site URL.
    /// </summary>
    [JsonPropertyName("auction_item_site")]
    public string AuctionItemSite { get; set; }

    /// <summary>
    /// The name of the auction site.
    /// </summary>
    [JsonPropertyName("auction_site")]
    public string AuctionSite { get; set; }
}
