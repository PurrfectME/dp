using System.Text.Json.Serialization;
using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Api.Endpoints.Payments.ShowRefundDetails;

internal sealed class ShowRefundDetailsResponse
{
    /// <summary>
    /// The amount that the payee refunded to the payer.
    /// </summary>
    [JsonPropertyName("amount")]
    public Money Amount { get; set; }

    /// <summary>
    /// The date and time when the transaction occurred, in Internet date and time format. Seconds are required while fractional seconds
    /// are optional.
    /// </summary>
    [JsonPropertyName("create_time")]
    public string CreateTime { get; set; }

    /// <summary>
    /// The PayPal-generated ID for the refund.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails
    /// that the payer receives.
    /// </summary>
    [JsonPropertyName("invoice_id")]
    public string InvoiceId { get; set; }

    /// <summary>
    /// An array of related HATEOAS links.
    /// </summary>
    [JsonPropertyName("links")]
    public LinkDescription[] Links { get; set; }

    /// <summary>
    /// The reason for the refund. Appears in both the payer's transaction history and the emails that the payer receives.
    /// </summary>
    [JsonPropertyName("note_to_payer")]
    public string NoteToPayer { get; set; }

    /// <summary>
    /// The breakdown of the refund.
    /// </summary>
    [JsonPropertyName("seller_payable_breakdown")]
    public SellerPayableBreakdown SellerPayableBreakdown { get; set; }

    /// <summary>
    /// The status of the refund.
    /// </summary>
    /// <value>
    /// "CANCELLED" - the refund was cancelled.<br/>
    /// "PENDING" - the refund is pending. For more information, see status_details.reason.<br/>
    /// "COMPLETED" - the funds for this transaction were debited to the customer's account.
    /// </value>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>
    /// The details of the refund status.
    /// </summary>
    [JsonPropertyName("status_details")]
    public RefundStatusDetails StatusDetails { get; set; }

    /// <summary>
    /// The date and time when the transaction was last updated, in Internet date and time format. Seconds are required while fractional
    /// seconds are optional.
    /// </summary>
    [JsonPropertyName("update_time")]
    public string UpdateTime { get; set; }
}
