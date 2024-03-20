using System.Text.Json.Serialization;
using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Api.Endpoints.Payments.CaptureAuthorizedPayment;

internal sealed class CaptureAuthorizedPaymentRequest : AuthorizedRequest
{
    /// <summary>
    /// The amount to capture. To capture a portion of the full authorized amount, specify an amount. If amount is not specified, the full
    /// authorized amount is captured. The amount must be a positive number and in the same currency as the authorization against which
    /// the payment is being captured.
    /// </summary>
    [JsonPropertyName("amount")]
    public Money Amount { get; set; }

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
    /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails
    /// that the payer receives.
    /// </summary>
    [JsonPropertyName("invoice_id")]
    public string InvoiceId { get; set; }

    /// <summary>
    /// An informational note about this settlement. Appears in both the payer's transaction history and the emails that the payer receives.
    /// </summary>
    [JsonPropertyName("note_to_payer")]
    public string NoteToPayer { get; set; }

    /// <summary>
    /// Any additional payment instructions to be consider during payment processing. This processing instruction is applicable for
    /// Capturing an order or Authorizing an Order.
    /// </summary>
    [JsonPropertyName("payment_instruction")]
    public PaymentInstruction PaymentInstruction { get; set; }

    /// <summary>
    /// The payment descriptor on the payer's account statement.
    /// </summary>
    [JsonPropertyName("soft_descriptor")]
    public string SoftDescriptor { get; set; }
}
