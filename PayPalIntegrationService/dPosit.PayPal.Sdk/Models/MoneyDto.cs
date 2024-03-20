using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class MoneyDto
{
    /// <summary>
    /// The currency.
    /// </summary>
    public Currency Currency { get; set; }

    /// <summary>
    /// The value, which might be:<br/>
    ///     - an integer for currencies like JPY that are not typically fractional <see cref="Constants.CurrencyCodesWithoutDecimalSupportMap"/>;<br/>
    ///     - a decimal fraction for currencies like TND that are subdivided into thousandths.
    /// </summary>
    public string Value { get; set; }

    private void Validate()
    {
        if (Currency is Currency.None)
        {
            throw new PayPalModelValidationException<MoneyDto>("Currency is required.");
        }

        if (string.IsNullOrWhiteSpace(Value))
        {
            throw new PayPalModelValidationException<MoneyDto>("Value is required.");
        }

        if (Constants.CurrencyCodesWithoutDecimalSupportMap.ContainsKey(Currency))
        {
            if (Value.Contains('.'))
            {
                throw new PayPalModelValidationException<MoneyDto>($"Decimal fraction is not supported for {Currency} currency.");
            }
        }

        if (!decimal.TryParse(Value, out _))
        {
            throw new PayPalModelValidationException<MoneyDto>($"Incorrect decimal value ${Value}.");
        }
    }

    internal Money ToRequestModel()
    {
        Validate();

        return new Money
        {
            CurrencyCode = Currency.GetStringValue(),
            Value = Value
        };
    }

    internal static MoneyDto CreateFromModel(Money model)
    {
        if (model is null)
        {
            return null;
        }

        return new MoneyDto
        {
            Currency = Helpers.ParseCurrencyValue(model.CurrencyCode),
            Value = model.Value
        };
    }
}
