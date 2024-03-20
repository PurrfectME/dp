using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class AmountWithBreakdown
{
    /// <summary>
    /// The three-character ISO-4217 currency code that identifies the currency.
    /// </summary>
    [JsonPropertyName("currency_code")]
    public string CurrencyCode { get; set; }

    /// <summary>
    /// The value, which might be:<br/>
    ///     - an integer for currencies like JPY that are not typically fractional <see cref="Constants.CurrencyCodesWithoutDecimalSupportMap"/>;<br/>
    ///     - a decimal fraction for currencies like TND that are subdivided into thousandths.
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }

    /// <summary>
    /// The breakdown of the amount. Breakdown provides details such as total item amount, total tax amount, shipping, handling, insurance,
    /// and discounts, if any.
    /// </summary>
    [JsonPropertyName("breakdown")]
    public AmountBreakdown Breakdown { get; set; }
}
