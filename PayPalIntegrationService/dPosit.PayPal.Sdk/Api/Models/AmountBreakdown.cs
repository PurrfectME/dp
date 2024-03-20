using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class AmountBreakdown
{
    /// <summary>
    /// The discount for all items within a given <c>purchase_unit</c>. <c>discount.value</c> can not be a negative number.
    /// </summary>
    [JsonPropertyName("discount")]
    public Money Discount { get; set; }

    /// <summary>
    /// The handling fee for all items within a given <c>purchase_unit</c>. <c>handling.value</c> can not be a negative number.
    /// </summary>
    [JsonPropertyName("handling")]
    public Money Handling { get; set; }

    /// <summary>
    /// The insurance fee for all items within a given <c>purchase_unit</c>. <c>insurance.value</c> can not be a negative number.
    /// </summary>
    [JsonPropertyName("insurance")]
    public Money Insurance { get; set; }

    /// <summary>
    /// The subtotal for all items. Required if the request includes <c>purchase_units[].items[].unit_amount</c>. Must equal the sum of
    /// <c>(items[].unit_amount * items[].quantity)</c> for all items. <c>item_total.value</c> can not be a negative number.
    /// </summary>
    [JsonPropertyName("item_total")]
    public Money ItemTotal { get; set; }

    /// <summary>
    /// The shipping fee for all items within a given <c>purchase_unit</c>. <c>shipping.value</c> can not be a negative number.
    /// </summary>
    [JsonPropertyName("shipping")]
    public Money Shipping { get; set; }

    /// <summary>
    /// The shipping discount for all items within a given <c>purchase_unit</c>. <c>shipping_discount.value</c> can not be a negative number.
    /// </summary>
    [JsonPropertyName("shipping_discount")]
    public Money ShippingDiscount { get; set; }

    /// <summary>
    /// The total tax for all items. Required if the request includes <c>purchase_units.items.tax</c>. Must equal the sum of
    /// <c>(items[].tax * items[].quantity)</c> for all items. <c>tax_total.value</c> can not be a negative number.
    /// </summary>
    [JsonPropertyName("tax_total")]
    public Money TaxTotal { get; set; }
}
