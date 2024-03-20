using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class ExchangeRate
{
    /// <summary>
    /// The source currency from which to convert an amount.
    /// </summary>
    /// <value>
    /// The three-character ISO-4217 currency code that identifies the currency.
    /// </value>
    [JsonPropertyName("source_currency")]
    public string SourceCurrency { get; set; }

    /// <summary>
    /// The target currency to which to convert an amount.
    /// </summary>
    /// <value>
    /// The three-character ISO-4217 currency code that identifies the currency.
    /// </value>
    [JsonPropertyName("target_currency")]
    public string TargetCurrency { get; set; }

    /// <summary>
    /// The target currency amount. Equivalent to one unit of the source currency. Formatted as integer or decimal value with one to 15
    /// digits to the right of the decimal point.
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
