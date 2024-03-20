using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class AuctionInfoDto
{
    /// <summary>
    /// The ID of the buyer who makes the purchase in the auction. This ID might be different from the payer ID provided for the payment.
    /// </summary>
    public string AuctionBuyerId { get; set; }

    /// <summary>
    /// The date and time when the auction closes, in Internet date and time format. Seconds are required while
    /// fractional seconds are optional.
    /// </summary>
    public DateTimeOffset AuctionClosingDate { get; set; }

    /// <summary>
    /// The auction site URL.
    /// </summary>
    public string AuctionItemSite { get; set; }

    /// <summary>
    /// The name of the auction site.
    /// </summary>
    public string AuctionSite { get; set; }

    internal static AuctionInfoDto CreateFromModel(AuctionInfo model)
    {
        if (model is null)
        {
            return null;
        }

        return new AuctionInfoDto
        {
            AuctionBuyerId = model.AuctionBuyerId,
            AuctionClosingDate = DateTimeOffset.Parse(model.AuctionClosingDate),
            AuctionItemSite = model.AuctionItemSite,
            AuctionSite = model.AuctionSite
        };
    }
}
