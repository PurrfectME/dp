using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class SellerPayableBreakdown
{
    /// <summary>
    /// The amount that the payee refunded to the payer.
    /// </summary>
    [JsonPropertyName("gross_amount")]
    public Money GrossAmount { get; set; }

    /// <summary>
    /// The net amount that the payee's account is debited in the transaction currency. The net amount is calculated as <c>gross_amount</c>
    /// minus <c>paypal_fee</c> minus <c>platform_fees</c>.
    /// </summary>
    [JsonPropertyName("net_amount")]
    public Money NetAmount { get; set; }

    /// <summary>
    /// An array of breakdown values for the net amount. Returned when the currency of the refund is different from the currency of the
    /// PayPal account where the payee holds their funds.
    /// </summary>
    [JsonPropertyName("net_amount_breakdown")]
    public NetAmountBreakdown[] NetAmountBreakdown { get; set; }

    /// <summary>
    /// The net amount that the payee's account is debited in the receivable currency. Returned only in cases when the receivable currency
    /// is different from transaction currency. Example 'CNY'.
    /// </summary>
    [JsonPropertyName("net_amount_in_receivable_currency")]
    public Money NetAmountInReceivableCurrency { get; set; }

    /// <summary>
    /// The PayPal fee that was refunded to the payer in the currency of the transaction. This fee might not match the PayPal fee that the
    /// payee paid when the payment was captured.
    /// </summary>
    [JsonPropertyName("paypal_fee")]
    public Money PayPalFee { get; set; }

    /// <summary>
    /// The PayPal fee that was refunded to the payer in the receivable currency. Returned only in cases when the receivable currency is
    /// different from transaction currency. Example 'CNY'.
    /// </summary>
    [JsonPropertyName("paypal_fee_in_receivable_currency")]
    public Money PaypalFeeInReceivableCurrency { get; set; }

    /// <summary>
    /// An array of platform or partner fees, commissions, or brokerage fees for the refund.
    /// </summary>
    [JsonPropertyName("platform_fees")]
    public PlatformFee[] PlatformFees { get; set; }

    /// <summary>
    /// The total amount refunded from the original capture to date. For example, if a payer makes a $100 purchase and was refunded $20
    /// a week ago and was refunded $30 in this refund, the <c>gross_amount</c> is $30 for this refund and the <c>total_refunded_amount</c>
    /// is $50.
    /// </summary>
    [JsonPropertyName("total_refunded_amount")]
    public Money TotalRefundedAmount { get; set; }
}
