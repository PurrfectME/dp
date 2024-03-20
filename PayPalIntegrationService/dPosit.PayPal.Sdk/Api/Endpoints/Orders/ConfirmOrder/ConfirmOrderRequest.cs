using System.Text.Json.Serialization;
using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Api.Endpoints.Orders.ConfirmOrder;

internal sealed class ConfirmOrderRequest : AuthorizedRequest
{
    /// <summary>
    /// The payment source definition.
    /// </summary>
    [JsonPropertyName("payment_source")]
    public PaymentSource PaymentSource { get; set; }

    /// <summary>
    /// Customizes the payer confirmation experience.
    /// </summary>
    [JsonPropertyName("application_context")]
    public OrderConfirmApplicationContext ApplicationContext { get; set; }

    /// <summary>
    /// The instruction to process an order.
    /// </summary>
    /// <value>
    /// "ORDER_COMPLETE_ON_PAYMENT_APPROVAL" - API Caller expects the Order to be auto completed (i.e. for PayPal to authorize or capture
    /// depending on the intent) on completion of payer approval. This option is not relevant for payment_source that typically do not
    /// require a payer approval or interaction. This option is currently only available for the following payment_source:
    /// Alipay, Bancontact, BLIK, boletobancario, eps, giropay, iDEAL, Multibanco, MyBank, OXXO, P24, PayU, PUI, SafetyPay, SatisPay,
    /// Sofort, Trustly, TrustPay, Verkkopankki, WeChat Pay.<br/>
    /// "NO_INSTRUCTION" - the API caller intends to authorize <c>v2/checkout/orders/id/authorize</c> or capture
    /// <c>v2/checkout/orders/id/capture</c> after the payer approves the order.
    /// </value>
    [JsonPropertyName("processing_instruction")]
    public string ProcessingInstruction { get; set; }
}
