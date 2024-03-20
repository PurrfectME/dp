namespace dPosit.PayPal.Sdk.Models;

public enum CaptureStatusReason
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// The payer initiated a dispute for this captured payment with PayPal.
    /// </summary>
    BuyerComplaint,
    /// <summary>
    /// The captured funds were reversed in response to the payer disputing this captured payment with the issuer of the
    /// financial instrument used to pay for this captured payment.
    /// </summary>
    Chargeback,
    /// <summary>
    /// The payer paid by an eCheck that has not yet cleared.
    /// </summary>
    Echeck,
    /// <summary>
    /// Visit your online account. In your **Account Overview**, accept and deny this payment.<br/>
    /// </summary>
    InternationalWithdrawal,
    /// <summary>
    /// No additional specific reason can be provided. For more information about this captured payment, visit your account
    /// online or contact PayPal.
    /// </summary>
    Other,
    /// <summary>
    /// The captured payment is pending manual review.
    /// </summary>
    PendingReview,
    /// <summary>
    /// The payee has not yet set up appropriate receiving preferences for their account.
    /// For more information about how to accept or deny this payment, visit your account online. This reason is typically offered in
    /// scenarios such as when the currency of the captured payment is different from the primary holding currency of the payee.
    /// </summary>
    ReceivingPreferenceMandatesManualAction,
    /// <summary>
    /// The captured funds were refunded.
    /// </summary>
    Refunded,
    /// <summary>
    /// The payer must send the funds for this captured payment. This code generally appears for manual EFTs.
    /// </summary>
    TransactionApprovedAwaitingFunding,
    /// <summary>
    /// The payee does not have a PayPal account.
    /// </summary>
    Unilateral,
    /// <summary>
    /// The payee's PayPal account is not verified.
    /// </summary>
    VerificationRequired
}
