using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class AmountWithBreakdownDto
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

    /// <summary>
    /// The breakdown of the amount. Breakdown provides details such as total item amount, total tax amount, shipping, handling, insurance,
    /// and discounts, if any.
    /// </summary>
    public AmountBreakdownDto Breakdown { get; set; }

    private void Validate()
    {
        if (Currency is Currency.None)
        {
            throw new PayPalModelValidationException<AmountWithBreakdownDto>("Currency is required.");
        }

        if (string.IsNullOrWhiteSpace(Value))
        {
            throw new PayPalModelValidationException<AmountWithBreakdownDto>("Value is required.");
        }

        if (Value.Length > 32)
        {
            throw new PayPalModelValidationException<AmountWithBreakdownDto>("Incorrect Value length.");
        }

        if (Value.StartsWith('-'))
        {
            throw new PayPalModelValidationException<AmountWithBreakdownDto>("Value can not be a negative number.");
        }

        if (Constants.CurrencyCodesWithoutDecimalSupportMap.ContainsKey(Currency))
        {
            if (Value.Contains('.'))
            {
                throw new PayPalModelValidationException<AmountWithBreakdownDto>($"Decimal fraction is not supported for {Currency} currency.");
            }
        }

        if (!decimal.TryParse(Value, out _))
        {
            throw new PayPalModelValidationException<AmountWithBreakdownDto>($"Incorrect decimal value ${Value}.");
        }

        if (Breakdown is not null)
        {
            var targetValue = decimal.Parse(Value);

            var decimalDiscount = decimal.Parse(Breakdown.Discount.Value);
            var decimalHandling = decimal.Parse(Breakdown.Handling.Value);
            var decimalInsurance = decimal.Parse(Breakdown.Insurance.Value);
            var decimalItemTotal = decimal.Parse(Breakdown.ItemTotal.Value);
            var decimalShipping = decimal.Parse(Breakdown.Shipping.Value);
            var decimalShippingDiscount = decimal.Parse(Breakdown.ShippingDiscount.Value);
            var decimalTaxTotal = decimal.Parse(Breakdown.TaxTotal.Value);

            // The amount should be equal <c>item_total</c> plus <c>tax_total</c> plus <c>shipping</c> plus <c>handling</c> plus
            // <c>insurance</c> minus <c>shipping_discount</c> minus <c>discount</c>.
            var value = decimalItemTotal + decimalTaxTotal + decimalShipping + decimalHandling + decimalInsurance - decimalShippingDiscount - decimalDiscount;

            if (value != targetValue)
            {
                throw new PayPalModelValidationException<AmountWithBreakdownDto>($"Value does not match with Breakdown.");
            }
        }
    }

    internal AmountWithBreakdown ToRequestModel()
    {
        Validate();

        return new AmountWithBreakdown
        {
            CurrencyCode = Currency.GetStringValue(),
            Value = Value,
            Breakdown = Breakdown?.ToRequestModel()
        };
    }

    internal static AmountWithBreakdownDto CreateFromModel(AmountWithBreakdown model)
    {
        if (model is null)
        {
            return null;
        }

        return new AmountWithBreakdownDto
        {
            Currency = Helpers.ParseCurrencyValue(model.CurrencyCode),
            Value = model.Value,
            Breakdown = AmountBreakdownDto.CreateFromModel(model.Breakdown)
        };
    }
}
