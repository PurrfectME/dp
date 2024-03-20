using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class ExchangeRateDto
{
    /// <summary>
    /// The source currency from which to convert an amount.
    /// </summary>
    public Currency SourceCurrency { get; set; }

    /// <summary>
    /// The target currency to which to convert an amount.
    /// </summary>
    public Currency TargetCurrency { get; set; }

    /// <summary>
    /// The target currency amount. Equivalent to one unit of the source currency. Formatted as integer or decimal value with one to 15
    /// digits to the right of the decimal point.
    /// </summary>
    public string Value { get; set; }

    internal static ExchangeRateDto CreateFromModel(ExchangeRate model)
    {
        if (model is null)
        {
            return null;
        }

        return new ExchangeRateDto
        {
            SourceCurrency = Helpers.ParseCurrencyValue(model.SourceCurrency),
            TargetCurrency = Helpers.ParseCurrencyValue(model.TargetCurrency),
            Value = model.Value
        };
    }
}
