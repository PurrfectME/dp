using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class ItemDto
{
    /// <summary>
    /// The item name or title.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The item quantity. Must be a whole number.
    /// </summary>
    public string Quantity { get; set; }

    /// <summary>
    /// The item price or rate per unit. If you specify <c>unit_amount</c>, <c>purchase_units[].amount.breakdown.item_total</c> is required.
    /// Must equal <c>unit_amount * quantity</c> for all items. <c>unit_amount.value</c> can not be a negative number.
    /// </summary>
    public MoneyDto UnitAmount { get; set; }

    /// <summary>
    /// The item category type.
    /// </summary>
    public ItemCategory Category { get; set; }

    /// <summary>
    /// The detailed item description.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The stock keeping unit (SKU) for the item.
    /// </summary>
    public string Sku { get; set; }

    /// <summary>
    /// The item tax for each unit. If <c>tax</c> is specified, <c>purchase_units[].amount.breakdown.tax_total</c> is required.
    /// Must equal <c>tax * quantity</c> for all items. <c>tax.value</c> can not be a negative number.
    /// </summary>
    public MoneyDto Tax { get; set; }

    private void Validate()
    {
        if (string.IsNullOrWhiteSpace(Name))
        {
            throw new PayPalModelValidationException<ItemDto>("Name is required.");
        }

        if (Name.Length > 127)
        {
            throw new PayPalModelValidationException<ItemDto>("Incorrect Name lenght.");
        }

        if (string.IsNullOrWhiteSpace(Quantity))
        {
            throw new PayPalModelValidationException<ItemDto>("Quantity is required.");
        }

        if (Quantity.Length > 10)
        {
            throw new PayPalModelValidationException<ItemDto>("Incorrect Quantity lenght.");
        }

        if (UnitAmount is null)
        {
            throw new PayPalModelValidationException<ItemDto>("UnitAmount is required.");
        }

        if (UnitAmount.Value.StartsWith('-'))
        {
            throw new PayPalModelValidationException<ItemDto>("UnitAmount.Value can not be a negative number.");
        }

        if (Description is not null && Description.Length > 127)
        {
            throw new PayPalModelValidationException<ItemDto>("Description Quantity lenght.");
        }

        if (Sku is not null && Sku.Length > 127)
        {
            throw new PayPalModelValidationException<ItemDto>("Description Sku lenght.");
        }

        if (Tax is not null && Tax.Value.StartsWith('-'))
        {
            throw new PayPalModelValidationException<ItemDto>("Tax.Value can not be a negative number.");
        }
    }

    internal Item ToRequestModel()
    {
        Validate();

        return new Item
        {
            Name = Name,
            Quantity = Quantity,
            UnitAmount = UnitAmount.ToRequestModel(),
            Category = Category.GetStringValue(),
            Description = Description,
            Sku = Sku,
            Tax = Tax?.ToRequestModel()
        };
    }

    internal static ItemDto CreateFromModel(Item model)
    {
        if (model is null)
        {
            return null;
        }

        return new ItemDto
        {
            Name = model.Name,
            Quantity = model.Quantity,
            UnitAmount = MoneyDto.CreateFromModel(model.UnitAmount),
            Category = Helpers.ParseItemCategoryValue(model.Category),
            Description = model.Description,
            Sku = model.Sku,
            Tax = MoneyDto.CreateFromModel(model.Tax)
        };
    }
}
