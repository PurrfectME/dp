using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class SellerReceivableBreakdownDto
{
    /// <summary>
    /// The amount for this captured payment in the currency of the transaction.
    /// </summary>
    public MoneyDto GrossAmount { get; set; }

    /// <summary>
    /// The exchange rate that determines the amount that is credited to the payee's PayPal account. Returned when the currency of the
    /// captured payment is different from the currency of the PayPal account where the payee wants to credit the funds.
    /// </summary>
    public ExchangeRateDto ExchangeRate { get; set; }

    /// <summary>
    /// The net amount that the payee receives for this captured payment in their PayPal account. The net amount is computed as
    /// <c>gross_amount</c> minus the <c>paypal_fee</c> minus the <c>platform_fees</c>.
    /// </summary>
    public MoneyDto NetAmount { get; set; }

    /// <summary>
    /// The applicable fee for this captured payment in the currency of the transaction.
    /// </summary>
    public MoneyDto PayPalFee { get; set; }

    /// <summary>
    /// The applicable fee for this captured payment in the receivable currency. Returned only in cases the fee is charged in the
    /// receivable currency. Example 'CNY'.
    /// </summary>
    public MoneyDto PaypalFeeInReceivableCurrency { get; set; }

    /// <summary>
    /// An array of platform or partner fees, commissions, or brokerage fees that associated with the captured payment.
    /// </summary>
    public PlatformFeeDto[] PlatformFees { get; set; }

    /// <summary>
    /// The net amount that is credited to the payee's PayPal account. Returned only when the currency of the captured payment is
    /// different from the currency of the PayPal account where the payee wants to credit the funds. The amount is computed as
    /// <c>net_amount</c> times <c>exchange_rate</c>.
    /// </summary>
    public MoneyDto ReceivableAmount { get; set; }

    internal static SellerReceivableBreakdownDto CreateFromModel(SellerReceivableBreakdown model)
    {
        if (model is null)
        {
            return null;
        }

        return new SellerReceivableBreakdownDto
        {
            GrossAmount = MoneyDto.CreateFromModel(model.GrossAmount),
            ExchangeRate = ExchangeRateDto.CreateFromModel(model.ExchangeRate),
            NetAmount = MoneyDto.CreateFromModel(model.NetAmount),
            PayPalFee = MoneyDto.CreateFromModel(model.PayPalFee),
            PaypalFeeInReceivableCurrency = MoneyDto.CreateFromModel(model.PaypalFeeInReceivableCurrency),
            PlatformFees = model.PlatformFees?.Select(PlatformFeeDto.CreateFromModel).ToArray(),
            ReceivableAmount = MoneyDto.CreateFromModel(model.ReceivableAmount)
        };
    }
}
