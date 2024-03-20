using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Exceptions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class AmountBreakdownDto
{
    /// <summary>
    /// The discount for all items within a given <c>purchase_unit</c>. <c>discount.value</c> can not be a negative number.
    /// </summary>
    public MoneyDto Discount { get; set; }

    /// <summary>
    /// The handling fee for all items within a given <c>purchase_unit</c>. <c>handling.value</c> can not be a negative number.
    /// </summary>
    public MoneyDto Handling { get; set; }

    /// <summary>
    /// The insurance fee for all items within a given <c>purchase_unit</c>. <c>insurance.value</c> can not be a negative number.
    /// </summary>
    public MoneyDto Insurance { get; set; }

    /// <summary>
    /// The subtotal for all items. Required if the request includes <c>purchase_units[].items[].unit_amount</c>. Must equal the sum of
    /// <c>(items[].unit_amount * items[].quantity)</c> for all items. <c>item_total.value</c> can not be a negative number.
    /// </summary>
    public MoneyDto ItemTotal { get; set; }

    /// <summary>
    /// The shipping fee for all items within a given <c>purchase_unit</c>. <c>shipping.value</c> can not be a negative number.
    /// </summary>
    public MoneyDto Shipping { get; set; }

    /// <summary>
    /// The shipping discount for all items within a given <c>purchase_unit</c>. <c>shipping_discount.value</c> can not be a negative number.
    /// </summary>
    public MoneyDto ShippingDiscount { get; set; }

    /// <summary>
    /// The total tax for all items. Required if the request includes <c>purchase_units.items.tax</c>. Must equal the sum of
    /// <c>(items[].tax * items[].quantity)</c> for all items. <c>tax_total.value</c> can not be a negative number.
    /// </summary>
    public MoneyDto TaxTotal { get; set; }

    private void Validate()
    {
        if (Discount is not null && Discount.Value.StartsWith('-'))
        {
            throw new PayPalModelValidationException<AmountBreakdownDto>("Discount.Value can not be a negative number.");
        }

        if (Handling is not null && Handling.Value.StartsWith('-'))
        {
            throw new PayPalModelValidationException<AmountBreakdownDto>("Handling.Value can not be a negative number.");
        }

        if (Insurance is not null && Insurance.Value.StartsWith('-'))
        {
            throw new PayPalModelValidationException<AmountBreakdownDto>("Insurance.Value can not be a negative number.");
        }

        if (ItemTotal is not null && ItemTotal.Value.StartsWith('-'))
        {
            throw new PayPalModelValidationException<AmountBreakdownDto>("ItemTotal.Value can not be a negative number.");
        }

        if (Shipping is not null && Shipping.Value.StartsWith('-'))
        {
            throw new PayPalModelValidationException<AmountBreakdownDto>("Shipping.Value can not be a negative number.");
        }

        if (ShippingDiscount is not null && ShippingDiscount.Value.StartsWith('-'))
        {
            throw new PayPalModelValidationException<AmountBreakdownDto>("ShippingDiscount.Value can not be a negative number.");
        }

        if (TaxTotal is not null && TaxTotal.Value.StartsWith('-'))
        {
            throw new PayPalModelValidationException<AmountBreakdownDto>("TaxTotal.Value can not be a negative number.");
        }
    }

    internal AmountBreakdown ToRequestModel()
    {
        Validate();

        return new AmountBreakdown
        {
            Discount = Discount?.ToRequestModel(),
            Handling = Handling?.ToRequestModel(),
            Insurance = Insurance?.ToRequestModel(),
            ItemTotal = ItemTotal?.ToRequestModel(),
            Shipping = Shipping?.ToRequestModel(),
            ShippingDiscount = ShippingDiscount?.ToRequestModel(),
            TaxTotal = TaxTotal?.ToRequestModel()
        };
    }

    internal static AmountBreakdownDto CreateFromModel(AmountBreakdown model)
    {
        if (model is null)
        {
            return null;
        }

        return new AmountBreakdownDto
        {
            Discount = MoneyDto.CreateFromModel(model.Discount),
            Handling = MoneyDto.CreateFromModel(model.Handling),
            Insurance = MoneyDto.CreateFromModel(model.Insurance),
            ItemTotal = MoneyDto.CreateFromModel(model.ItemTotal),
            Shipping = MoneyDto.CreateFromModel(model.Shipping),
            ShippingDiscount = MoneyDto.CreateFromModel(model.ShippingDiscount),
            TaxTotal = MoneyDto.CreateFromModel(model.TaxTotal)
        };
    }
}
