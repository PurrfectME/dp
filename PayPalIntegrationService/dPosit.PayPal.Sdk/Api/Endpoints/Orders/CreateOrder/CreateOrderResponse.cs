using System.Text.Json.Serialization;
using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Api.Endpoints.Orders.CreateOrder;

internal sealed class CreateOrderResponse
{
    /// <summary>
    /// The date and time when the transaction occurred, in Internet date and time format.
    /// </summary>
    /// <remarks>Read only.</remarks>
    [JsonPropertyName("create_time")]
    public string CreateTime { get; set; }

    /// <summary>
    /// The ID of the order.
    /// </summary>
    /// <remarks>Read only.</remarks>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// The intent to either capture payment immediately or authorize a payment for an order after order creation.
    /// </summary>
    /// <value>
    /// "CAPTURE" - the merchant intends to capture payment immediately after the customer makes a payment.<br/>
    /// "AUTHORIZE" - the merchant intends to authorize a payment and place funds on hold after the customer makes a payment. Authorized
    /// payments are best captured within three days of authorization but are available to capture for up to 29 days. After the three-day
    /// honor period, the original authorized payment expires and you must re-authorize the payment. You must make a separate request to
    /// capture payments on demand. This intent is not supported when you have more than one `purchase_unit` within your order.
    /// </value>
    [JsonPropertyName("intent")]
    public string Intent { get; set; }

    /// <summary>
    /// An array of request-related HATEOAS links. To complete payer <c>approval</c>, use the approve link to redirect the payer. The API
    /// caller has 3 hours (default setting, this which can be changed by your account manager to 24/48/72 hours to accommodate your use
    /// case) from the time the order is created, to redirect your payer. Once redirected, the API caller has 3 hours for the payer to
    /// approve the order and either authorize or capture the order. If you are not using the PayPal JavaScript SDK to initiate PayPal
    /// Checkout (in context) ensure that you include <c>application_context.return_url</c> is specified or you will get "We're sorry,
    /// Things don't appear to be working at the moment" after the payer approves the payment.
    /// </summary>
    [JsonPropertyName("links")]
    public LinkDescription[] Links { get; set; }

    /// <summary>
    /// The payment source used to fund the payment.
    /// </summary>
    [JsonPropertyName("payment_source")]
    public PaymentSourceResponse PaymentSource { get; set; }

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

    /// <summary>
    /// An array of purchase units. Each purchase unit establishes a contract between a customer and merchant. Each purchase unit represents
    /// either a full or partial order that the customer intends to purchase from the merchant.
    /// </summary>
    [JsonPropertyName("purchase_units")]
    public PurchaseUnit[] PurchaseUnits { get; set; }

    /// <summary>
    /// The order status.
    /// </summary>
    /// <value>
    /// "CREATED" - the order was created with the specified context.<br/>
    /// "SAVED" - the order was saved and persisted. The order status continues to be in progress until a capture is made with
    /// <c>final_capture = true</c> for all purchase units within the order.<br/>
    /// "APPROVED" - the customer approved the payment through the PayPal wallet or another form of guest or unbranded payment.
    /// For example, a card, bank account, or so on.<br/>
    /// "VOIDED" - all purchase units in the order are voided.<br/>
    /// "COMPLETED" - the payment was authorized or the authorized payment was captured for the order.<br/>
    /// "PAYER_ACTION_REQUIRED" - the order requires an action from the payer (e.g. 3DS authentication). Redirect the payer to the
    /// "rel":"payer-action" HATEOAS link returned as part of the response prior to authorizing or capturing the order.
    /// </value>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>
    /// The date and time when the transaction was last updated, in Internet date and time format. Seconds are required while fractional
    /// seconds are optional.
    /// </summary>
    [JsonPropertyName("update_time")]
    public string UpdateTime { get; set; }
}
