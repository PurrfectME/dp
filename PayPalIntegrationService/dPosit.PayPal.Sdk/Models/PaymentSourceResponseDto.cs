using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class PaymentSourceResponseDto
{
    /// <summary>
    /// Information used to pay Bancontact.
    /// </summary>
    public BancontactDto Bancontact { get; set; }

    /// <summary>
    /// Information used to pay using BLIK.
    /// </summary>
    public BlikDto Blik { get; set; }

    /// <summary>
    /// The payment card to use to fund a payment. Card can be a credit or debit card.
    /// </summary>
    public CardResponseDto Card { get; set; }

    /// <summary>
    /// Information used to pay using eps.
    /// </summary>
    public EpsDto Eps { get; set; }

    /// <summary>
    /// Information needed to pay using giropay.
    /// </summary>
    public GiropayDto Giropay { get; set; }

    /// <summary>
    /// Information used to pay using iDEAL.
    /// </summary>
    public IdealDto Ideal { get; set; }

    /// <summary>
    /// Information used to pay using MyBank.
    /// </summary>
    public MyBankDto MyBank { get; set; }

    /// <summary>
    /// Information used to pay using P24 (Przelewy24).
    /// </summary>
    public P24Dto P24 { get; set; }

    /// <summary>
    /// Information used to pay using Sofort.
    /// </summary>
    public SofortDto Sofort { get; set; }

    /// <summary>
    /// Information needed to pay using Trustly.
    /// </summary>
    public TrustlyDto Trustly { get; set; }

    internal static PaymentSourceResponseDto CreateFromModel(PaymentSourceResponse model)
    {
        if (model is null)
        {
            return null;
        }

        return new PaymentSourceResponseDto
        {
            Bancontact = BancontactDto.CreateFromModel(model.Bancontact),
            Blik = BlikDto.CreateFromModel(model.Blik),
            Card = CardResponseDto.CreateFromModel(model.Card),
            Eps = EpsDto.CreateFromModel(model.Eps),
            Giropay = GiropayDto.CreateFromModel(model.Giropay),
            Ideal = IdealDto.CreateFromModel(model.Ideal),
            MyBank = MyBankDto.CreateFromModel(model.MyBank),
            P24 = P24Dto.CreateFromModel(model.P24),
            Sofort = SofortDto.CreateFromModel(model.Sofort),
            Trustly = TrustlyDto.CreateFromModel(model.Trustly)
        };
    }
}
