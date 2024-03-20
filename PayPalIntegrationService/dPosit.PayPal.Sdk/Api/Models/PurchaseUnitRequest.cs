using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class PurchaseUnitRequest
{
    /// <summary>
    /// The total order amount with an optional breakdown that provides details, such as the total item amount, total tax amount, shipping,
    /// handling, insurance, and discounts, if any. If you specify <c>amount.breakdown</c>, the amount equals <c>item_total</c> plus
    /// <c>tax_total</c> plus <c>shipping</c> plus <c>handling</c> plus <c>insurance</c> minus <c>shipping_discount</c> minus <c>discount</c>.
    /// The amount must be a positive number.
    /// </summary>
    [JsonPropertyName("amount")]
    public AmountWithBreakdown Amount { get; set; }

    /// <summary>
    /// The API caller-provided external ID. Used to reconcile client transactions with PayPal transactions. Appears in transaction and
    /// settlement reports but is not visible to the payer.
    /// </summary>
    [JsonPropertyName("custom_id")]
    public string CustomId { get; set; }

    /// <summary>
    /// The purchase description. The maximum length of the character is dependent on the type of characters used. The character length is
    /// specified assuming a US ASCII character. Depending on type of character; (e.g. accented character, Japanese characters) the number
    /// of characters that that can be specified as input might not equal the permissible max length.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that
    /// the payer receives.
    /// </summary>
    [JsonPropertyName("invoice_id")]
    public string InvoiceId { get; set; }

    /// <summary>
    /// An array of items that the customer purchases from the merchant.
    /// </summary>
    [JsonPropertyName("items")]
    public Item[] Items { get; set; }

    /// <summary>
    /// The merchant who receives payment for this transaction.
    /// </summary>
    [JsonPropertyName("payee")]
    public Payee Payee { get; set; }

    /// <summary>
    /// Any additional payment instructions to be consider during payment processing. This processing instruction is applicable for
    /// Capturing an order or Authorizing an Order.
    /// </summary>
    [JsonPropertyName("payment_instruction")]
    public PaymentInstruction PaymentInstruction { get; set; }

    /// <summary>
    /// The API caller-provided external ID for the purchase unit.
    /// </summary>
    /// <remarks>
    /// Required for multiple purchase units when you must update the order through <с>PATCH</с>. If you omit this value and the order
    /// contains only one purchase unit, PayPal sets this value to <c>default</c>.
    /// </remarks>
    [JsonPropertyName("reference_id")]
    public string ReferenceId { get; set; }

    /// <summary>
    /// The name and address of the person to whom to ship the items.
    /// </summary>
    [JsonPropertyName("shipping")]
    public ShippingDetail ShippingDetail { get; set; }

    /// <summary>
    /// The soft descriptor is the dynamic text used to construct the statement descriptor that appears on a payer's card statement.
    /// </summary>
    /// <remarks>
    /// If an Order is paid using the "PayPal Wallet", the statement descriptor will appear in following format on the payer's card
    /// statement: <c>PAYPAL_prefix+(space)+merchant_descriptor+(space)+soft_descriptor</c>.
    /// </remarks>
    [JsonPropertyName("soft_descriptor")]
    public string SoftDescriptor { get; set; }
}
