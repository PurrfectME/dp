namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class Money
{
    /// <summary>
    /// The three-character ISO-4217 currency code that identifies the currency.
    /// </summary>
    public string CurrencyCode { get; set; }

    /// <summary>
    /// The value, which might be:<br/>
    ///     - an integer for currencies like JPY that are not typically fractional <see cref="Constants.CurrencyCodesWithoutDecimalSupportMap"/>;<br/>
    ///     - a decimal fraction for currencies like TND that are subdivided into thousandths.
    /// </summary>
    public string Value { get; set; }
}
