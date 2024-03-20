using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class ItemDetailTaxAmount
{
    /// <summary>
    /// The tax levied by a government on the purchase of goods or services.
    /// </summary>
    [JsonPropertyName("tax_amount")]
    public Money TaxAmount { get; set; }
}
