using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class CaptureStatusDetails
{
    /// <summary>
    /// The reason why the captured payment status is <c>PENDING</c> or <c>DENIED</c>.
    /// </summary>
    /// <value>
    /// "BUYER_COMPLAINT" - the payer initiated a dispute for this captured payment with PayPal.<br/>
    /// "CHARGEBACK" - the captured funds were reversed in response to the payer disputing this captured payment with the issuer of the
    /// financial instrument used to pay for this captured payment.<br/>
    /// "ECHECK" - the payer paid by an eCheck that has not yet cleared.<br/>
    /// "INTERNATIONAL_WITHDRAWAL" - visit your online account. In your **Account Overview**, accept and deny this payment.<br/>
    /// "OTHER" - no additional specific reason can be provided. For more information about this captured payment, visit your account
    /// online or contact PayPal.<br/>
    /// "PENDING_REVIEW" - the captured payment is pending manual review.<br/>
    /// "RECEIVING_PREFERENCE_MANDATES_MANUAL_ACTION" - the payee has not yet set up appropriate receiving preferences for their account.
    /// For more information about how to accept or deny this payment, visit your account online. This reason is typically offered in
    /// scenarios such as when the currency of the captured payment is different from the primary holding currency of the payee.<br/>
    /// "REFUNDED" - the captured funds were refunded.<br/>
    /// "TRANSACTION_APPROVED_AWAITING_FUNDING" - the payer must send the funds for this captured payment. This code generally appears
    /// for manual EFTs.<br/>
    /// "UNILATERAL" - the payee does not have a PayPal account.<br/>
    /// "VERIFICATION_REQUIRED" - the payee's PayPal account is not verified.
    /// </value>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }
}
