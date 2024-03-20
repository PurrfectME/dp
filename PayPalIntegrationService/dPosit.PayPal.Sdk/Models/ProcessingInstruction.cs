namespace dPosit.PayPal.Sdk.Models;

public enum ProcessingInstruction
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// API Caller expects the Order to be auto completed (i.e. for PayPal to authorize or capture
    /// depending on the intent) on completion of payer approval. This option is not relevant for payment_source that typically do not
    /// require a payer approval or interaction. This option is currently only available for the following payment_source:
    /// Alipay, Bancontact, BLIK, boletobancario, eps, giropay, iDEAL, Multibanco, MyBank, OXXO, P24, PayU, PUI, SafetyPay, SatisPay,
    /// Sofort, Trustly, TrustPay, Verkkopankki, WeChat Pay.
    /// </summary>
    OrderCompleteOnPaymentApproval,
    /// <summary>
    /// The API caller intends to authorize <c>v2/checkout/orders/id/authorize</c> or capture
    /// <c>v2/checkout/orders/id/capture</c> after the payer approves the order.
    /// </summary>
    NoInstruction
}
