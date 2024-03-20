using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class ItemDetail
{
    /// <summary>
    /// An increment or decrement to a purchase amount.
    /// </summary>
    [JsonPropertyName("adjustment_amount")]
    public Money AdjustmentAmount { get; set; }

    /// <summary>
    /// The delivery cost.
    /// </summary>
    [JsonPropertyName("basic_shipping_amount")]
    public Money BasicShippingAmount { get; set; }

    /// <summary>
    /// An array of checkout options. Each option has a name and value.
    /// </summary>
    [JsonPropertyName("checkout_options")]
    public CheckoutOption[] CheckoutOptions { get; set; }

    /// <summary>
    /// The reduction in price associated with goods or a service.
    /// </summary>
    [JsonPropertyName("discount_amount")]
    public Money DiscountAmount { get; set; }

    /// <summary>
    /// The cost for expedited delivery of the goods.
    /// </summary>
    [JsonPropertyName("extra_shipping_amount")]
    public Money ExtraShippingAmount { get; set; }

    /// <summary>
    /// The amount of money charged for gift wrapping an item.
    /// </summary>
    [JsonPropertyName("gift_wrap_amount")]
    public Money GiftWrapAmount { get; set; }

    /// <summary>
    /// A charge for processing the purchase of goods or services.
    /// </summary>
    [JsonPropertyName("handling_amount")]
    public Money HandlingAmount { get; set; }

    /// <summary>
    /// A charge for guaranteeing the quality of a product or delivery of a product.
    /// </summary>
    [JsonPropertyName("insurance_amount")]
    public Money InsuranceAmount { get; set; }

    /// <summary>
    /// The invoice number. An alphanumeric string that identifies a billing for a merchant.
    /// </summary>
    [JsonPropertyName("invoice_number")]
    public string InvoiceNumber { get; set; }

    /// <summary>
    /// The amount of the payment for the item.
    /// </summary>
    [JsonPropertyName("item_amount")]
    public Money ItemAmount { get; set; }

    /// <summary>
    /// An item code that identifies a merchant's goods or service.
    /// </summary>
    [JsonPropertyName("item_code")]
    public string ItemCode { get; set; }

    /// <summary>
    /// The item description.
    /// </summary>
    [JsonPropertyName("item_description")]
    public string ItemDescription { get; set; }

    /// <summary>
    /// The item name.
    /// </summary>
    [JsonPropertyName("item_name")]
    public string ItemName { get; set; }

    /// <summary>
    /// The item options. Describes option choices on the purchase of the item in some detail.
    /// </summary>
    [JsonPropertyName("item_options")]
    public string ItemOptions { get; set; }

    /// <summary>
    /// The number of purchased units of goods or a service.
    /// </summary>
    [JsonPropertyName("item_quantity")]
    public string ItemQuantity { get; set; }

    /// <summary>
    /// The cost for each instance of goods or a service.
    /// </summary>
    [JsonPropertyName("item_unit_price")]
    public Money ItemUnitPrice { get; set; }

    /// <summary>
    /// An array of tax amounts levied by a government on the purchase of goods or services.
    /// </summary>
    [JsonPropertyName("tax_amounts")]
    public ItemDetailTaxAmount[] TaxAmounts { get; set; }

    /// <summary>
    /// A rate, expressed in hundreds, that is used to calculate a levy for the purchase of goods or services.
    /// </summary>
    /// <value>
    /// The percentage, as a fixed-point, signed decimal number. For example, define a 19.99% interest rate as <c>19.99</c>.
    /// </value>
    [JsonPropertyName("tax_percentage")]
    public string TaxPercentage { get; set; }

    /// <summary>
    /// The sum of all factors, item cost, discounts, tax, shipping, and so on, that goes into the cost of an item.
    /// </summary>
    [JsonPropertyName("total_item_amount")]
    public Money TotalItemAmount { get; set; }
}
