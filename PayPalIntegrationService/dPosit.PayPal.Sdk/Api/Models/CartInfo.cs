using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class CartInfo
{
    /// <summary>
    /// An array of item details.
    /// </summary>
    [JsonPropertyName("item_details")]
    public ItemDetail[] ItemDetails { get; set; }

    /// <summary>
    /// The ID of the invoice. Appears for only PayPal-generated invoices.
    /// </summary>
    [JsonPropertyName("paypal_invoice_id")]
    public string PayPalInvoiceId { get; set; }

    /// <summary>
    /// Indicates whether the item amount or the shipping amount already includes tax.
    /// </summary>
    [JsonPropertyName("tax_inclusive")]
    public bool? TaxInclusive { get; set; }
}
