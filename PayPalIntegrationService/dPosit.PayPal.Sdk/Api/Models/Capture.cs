using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class Capture
{
    /// <summary>
    /// The status of the captured payment.
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>
    /// The details of the captured payment status.
    /// </summary>
    [JsonPropertyName("status_details")]
    public CaptureStatusDetails StatusDetails { get; set; }

    /// <summary>
    /// The amount for this captured payment.
    /// </summary>
    [JsonPropertyName("amount")]
    public Money Amount { get; set; }

    /// <summary>
    /// The API caller-provided external ID. Used to reconcile API caller-initiated transactions with PayPal transactions. Appears in
    /// transaction and settlement reports.
    /// </summary>
    [JsonPropertyName("custom_id")]
    public string CustomId { get; set; }

    /// <summary>
    /// The funds that are held on behalf of the merchant.
    /// </summary>
    /// <value>
    /// "INSTANT" - the funds are released to the merchant immediately.<br/>
    /// "DELAYED" - the funds are held for a finite number of days. The actual duration depends on the region and type of integration.
    /// You can release the funds through a referenced payout. Otherwise, the funds disbursed automatically after the specified duration.
    /// </value>
    [JsonPropertyName("disbursement_mode")]
    public string DisbursementMode { get; set; }

    /// <summary>
    /// Indicates whether you can make additional captures against the authorized payment.
    /// </summary>
    /// <value>
    /// <c>true</c> - if you do not intend to capture additional payments against the authorization.<br/>
    /// <c>false</c> - if you intend to capture additional payments against the authorization.
    /// </value>
    [JsonPropertyName("final_capture")]
    public bool? FinalCapture { get; set; }

    /// <summary>
    /// The PayPal-generated ID for the captured payment.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that
    /// the payer receives.
    /// </summary>
    [JsonPropertyName("invoice_id")]
    public string InvoiceId { get; set; }

    /// <summary>
    /// An array of related HATEOAS links.
    /// </summary>
    [JsonPropertyName("links")]
    public LinkDescription[] Links { get; set; }

    /// <summary>
    /// An object that provides additional processor information for a direct credit card transaction.
    /// </summary>
    [JsonPropertyName("processor_response")]
    public ProcessorResponse ProcessorResponse { get; set; }

    /// <summary>
    /// The level of protection offered as defined by PayPal Seller Protection for Merchants.
    /// </summary>
    [JsonPropertyName("seller_protection")]
    public SellerProtection SellerProtection { get; set; }

    /// <summary>
    /// The detailed breakdown of the capture activity. This is not available for transactions that are in pending state.
    /// </summary>
    [JsonPropertyName("seller_receivable_breakdown")]
    public SellerReceivableBreakdown SellerReceivableBreakdown { get; set; }

    /// <summary>
    /// The date and time when the transaction occurred, in Internet date and time format. Seconds are required while fractional seconds
    /// are optional.
    /// </summary>
    [JsonPropertyName("create_time")]
    public string CreateTime { get; set; }

    /// <summary>
    /// The date and time when the transaction was last updated, in Internet date and time format. Seconds are required while fractional
    /// seconds are optional.
    /// </summary>
    [JsonPropertyName("update_time")]
    public string UpdateTime { get; set; }
}
