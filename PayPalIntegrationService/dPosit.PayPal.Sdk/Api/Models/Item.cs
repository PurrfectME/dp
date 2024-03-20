using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class Item
{
    /// <summary>
    /// The item name or title.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The item quantity. Must be a whole number.
    /// </summary>
    [JsonPropertyName("quantity")]
    public string Quantity { get; set; }

    /// <summary>
    /// The item price or rate per unit. If you specify <c>unit_amount</c>, <c>purchase_units[].amount.breakdown.item_total</c> is required.
    /// Must equal <c>unit_amount * quantity</c> for all items. <c>unit_amount.value</c> can not be a negative number.
    /// </summary>
    [JsonPropertyName("unit_amount")]
    public Money UnitAmount { get; set; }

    /// <summary>
    /// The item category type.
    /// </summary>
    /// <value>
    /// "DIGITAL_GOODS" - goods that are stored, delivered, and used in their electronic format. This value is not currently supported for
    /// API callers that leverage the PayPal for Commerce Platform product.<br/>
    /// "PHYSICAL_GOODS" - a tangible item that can be shipped with proof of delivery.<br/>
    /// "DONATION" - a contribution or gift for which no good or service is exchanged, usually to a not for profit organization.
    /// </value>
    [JsonPropertyName("category")]
    public string Category { get; set; }

    /// <summary>
    /// The detailed item description.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The stock keeping unit (SKU) for the item.
    /// </summary>
    [JsonPropertyName("sku")]
    public string Sku { get; set; }

    /// <summary>
    /// The item tax for each unit. If <c>tax</c> is specified, <c>purchase_units[].amount.breakdown.tax_total</c> is required.
    /// Must equal <c>tax * quantity</c> for all items. <c>tax.value</c> can not be a negative number.
    /// </summary>
    [JsonPropertyName("tax")]
    public Money Tax { get; set; }
}
