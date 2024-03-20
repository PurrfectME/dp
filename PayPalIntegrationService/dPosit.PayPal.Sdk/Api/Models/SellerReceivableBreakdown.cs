using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class SellerReceivableBreakdown
{
    /// <summary>
    /// The amount for this captured payment in the currency of the transaction.
    /// </summary>
    [JsonPropertyName("gross_amount")]
    public Money GrossAmount { get; set; }

    /// <summary>
    /// The exchange rate that determines the amount that is credited to the payee's PayPal account. Returned when the currency of the
    /// captured payment is different from the currency of the PayPal account where the payee wants to credit the funds.
    /// </summary>
    [JsonPropertyName("exchange_rate")]
    public ExchangeRate ExchangeRate { get; set; }

    /// <summary>
    /// The net amount that the payee receives for this captured payment in their PayPal account. The net amount is computed as
    /// <c>gross_amount</c> minus the <c>paypal_fee</c> minus the <c>platform_fees</c>.
    /// </summary>
    [JsonPropertyName("net_amount")]
    public Money NetAmount { get; set; }

    /// <summary>
    /// The applicable fee for this captured payment in the currency of the transaction.
    /// </summary>
    [JsonPropertyName("paypal_fee")]
    public Money PayPalFee { get; set; }

    /// <summary>
    /// The applicable fee for this captured payment in the receivable currency. Returned only in cases the fee is charged in the
    /// receivable currency. Example 'CNY'.
    /// </summary>
    [JsonPropertyName("paypal_fee_in_receivable_currency")]
    public Money PaypalFeeInReceivableCurrency { get; set; }

    /// <summary>
    /// An array of platform or partner fees, commissions, or brokerage fees that associated with the captured payment.
    /// </summary>
    [JsonPropertyName("platform_fees")]
    public PlatformFee[] PlatformFees { get; set; }

    /// <summary>
    /// The net amount that is credited to the payee's PayPal account. Returned only when the currency of the captured payment is
    /// different from the currency of the PayPal account where the payee wants to credit the funds. The amount is computed as
    /// <c>net_amount</c> times <c>exchange_rate</c>.
    /// </summary>
    [JsonPropertyName("receivable_amount")]
    public Money ReceivableAmount { get; set; }
}
