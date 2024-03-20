using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class TransactionDetailDto
{
    /// <summary>
    /// The auction information.
    /// </summary>
    public AuctionInfoDto AuctionInfo { get; set; }

    /// <summary>
    /// The cart information.
    /// </summary>
    public CartInfoDto CartInfo { get; set; }

    /// <summary>
    /// The incentive information.
    /// </summary>
    public IncentiveInfoDto IncentiveInfo { get; set; }

    /// <summary>
    /// The payer information.
    /// </summary>
    public PayerInfoDto PayerInfo { get; set; }

    /// <summary>
    /// The shipping information.
    /// </summary>
    public ShippingInfoDto ShippingInfo { get; set; }

    /// <summary>
    /// The store information.
    /// </summary>
    public StoreInfoDto StoreInfo { get; set; }

    /// <summary>
    /// The transaction information.
    /// </summary>
    public TransactionInfoDto TransactionInfo { get; set; }

    internal static TransactionDetailDto CreateFromModel(TransactionDetail model)
    {
        if (model is null)
        {
            return null;
        }

        return new TransactionDetailDto
        {
            AuctionInfo = AuctionInfoDto.CreateFromModel(model.AuctionInfo),
            CartInfo = CartInfoDto.CreateFromModel(model.CartInfo),
            IncentiveInfo = IncentiveInfoDto.CreateFromModel(model.IncentiveInfo),
            PayerInfo = PayerInfoDto.CreateFromModel(model.PayerInfo),
            ShippingInfo = ShippingInfoDto.CreateFromModel(model.ShippingInfo),
            StoreInfo = StoreInfoDto.CreateFromModel(model.StoreInfo),
            TransactionInfo = TransactionInfoDto.CreateFromModel(model.TransactionInfo)
        };
    }
}
