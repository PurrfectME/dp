using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class PaymentInstruction
{
    /// <summary>
    /// The funds that are held payee by the marketplace/platform.
    /// </summary>
    /// <remarks>
    /// This field is only applicable to merchants that been enabled for PayPal Commerce Platform for Marketplaces and Platforms capability.
    /// </remarks>
    /// <value>
    /// "INSTANT" - the funds are released to the merchant immediately.<br/>
    /// "DELAYED" - the funds are held for a finite number of days. The actual duration depends on the region and type of integration.
    /// You can release the funds through a referenced payout. Otherwise, the funds disbursed automatically after the specified duration.
    /// </value>
    [JsonPropertyName("disbursement_mode")]
    public string DisbursementMode { get; set; }

    /// <summary>
    /// This field is only enabled for selected merchants/partners to use and provides the ability to trigger a specific pricing rate/plan
    /// for a payment transaction. The list of eligible 'payee_pricing_tier_id' would be provided to you by your Account Manager.
    /// Specifying values other than the one provided to you by your account manager would result in an error.
    /// </summary>
    [JsonPropertyName("payee_pricing_tier_id")]
    public string PayeePricingTierId { get; set; }

    /// <summary>
    /// FX identifier generated returned by PayPal to be used for payment processing in order to honor FX rate (for eligible integrations)
    /// to be used when amount is settled/received into the payee account.
    /// </summary>
    [JsonPropertyName("payee_receivable_fx_rate_id")]
    public string PayeeReceivableFxRateId { get; set; }

    /// <summary>
    /// An array of various fees, commissions, tips, or donations.
    /// </summary>
    /// <remarks>
    /// This field is only applicable to merchants that been enabled for PayPal Commerce Platform for Marketplaces and Platforms capability.
    /// </remarks>
    [JsonPropertyName("platform_fees")]
    public PlatformFee[] PlatformFees { get; set; }
}
