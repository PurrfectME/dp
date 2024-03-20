using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class SellerPayableBreakdownDto
{
    /// <summary>
    /// The amount that the payee refunded to the payer.
    /// </summary>
    public MoneyDto GrossAmount { get; set; }

    /// <summary>
    /// The net amount that the payee's account is debited in the transaction currency. The net amount is calculated as <c>gross_amount</c>
    /// minus <c>paypal_fee</c> minus <c>platform_fees</c>.
    /// </summary>
    public MoneyDto NetAmount { get; set; }

    /// <summary>
    /// An array of breakdown values for the net amount. Returned when the currency of the refund is different from the currency of the
    /// PayPal account where the payee holds their funds.
    /// </summary>
    public NetAmountBreakdownDto[] NetAmountBreakdown { get; set; }

    /// <summary>
    /// The net amount that the payee's account is debited in the receivable currency. Returned only in cases when the receivable currency
    /// is different from transaction currency. Example 'CNY'.
    /// </summary>
    public MoneyDto NetAmountInReceivableCurrency { get; set; }

    /// <summary>
    /// The PayPal fee that was refunded to the payer in the currency of the transaction. This fee might not match the PayPal fee that the
    /// payee paid when the payment was captured.
    /// </summary>
    public MoneyDto PayPalFee { get; set; }

    /// <summary>
    /// The PayPal fee that was refunded to the payer in the receivable currency. Returned only in cases when the receivable currency is
    /// different from transaction currency. Example 'CNY'.
    /// </summary>
    public MoneyDto PaypalFeeInReceivableCurrency { get; set; }

    /// <summary>
    /// An array of platform or partner fees, commissions, or brokerage fees for the refund.
    /// </summary>
    public PlatformFeeDto[] PlatformFees { get; set; }

    /// <summary>
    /// The total amount refunded from the original capture to date. For example, if a payer makes a $100 purchase and was refunded $20
    /// a week ago and was refunded $30 in this refund, the <c>gross_amount</c> is $30 for this refund and the <c>total_refunded_amount</c>
    /// is $50.
    /// </summary>
    public MoneyDto TotalRefundedAmount { get; set; }

    internal static SellerPayableBreakdownDto CreateFromModel(SellerPayableBreakdown model)
    {
        if (model is null)
        {
            return null;
        }

        return new SellerPayableBreakdownDto
        {
            GrossAmount = MoneyDto.CreateFromModel(model.GrossAmount),
            NetAmount = MoneyDto.CreateFromModel(model.NetAmount),
            NetAmountBreakdown = model.NetAmountBreakdown?.Select(NetAmountBreakdownDto.CreateFromModel).ToArray(),
            NetAmountInReceivableCurrency = MoneyDto.CreateFromModel(model.NetAmountInReceivableCurrency),
            PayPalFee = MoneyDto.CreateFromModel(model.PayPalFee),
            PaypalFeeInReceivableCurrency = MoneyDto.CreateFromModel(model.PaypalFeeInReceivableCurrency),
            PlatformFees = model.PlatformFees?.Select(PlatformFeeDto.CreateFromModel).ToArray(),
            TotalRefundedAmount = MoneyDto.CreateFromModel(model.TotalRefundedAmount)
        };
    }
}
