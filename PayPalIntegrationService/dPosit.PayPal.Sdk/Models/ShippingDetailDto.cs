using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class ShippingDetailDto
{
    /// <summary>
    /// The address of the person to whom to ship the items. Supports only the <c>address_line_1</c>, <c>address_line_2</c>,
    /// <c>admin_area_1</c>, <c>admin_area_2</c>, <c>postal_code</c>, and <c>country_code</c> properties.
    /// </summary>
    public AddressPortableDto Address { get; set; }

    /// <summary>
    /// The name of the person to whom to ship the items. Supports only the <c>full_name</c> property.
    /// </summary>
    public NameDto Name { get; set; }

    /// <summary>
    /// The method by which the payer wants to get their items from the payee e.g shipping, in-person pickup.
    /// </summary>
    public ShippingType Type { get; set; }

    internal ShippingDetail ToRequestModel()
    {
        return new ShippingDetail
        {
            Address = Address?.ToRequestModel(),
            Name = Name?.ToRequestModel(),
            Type = Type.GetStringValue()
        };
    }

    internal static ShippingDetailDto CreateFromModel(ShippingDetail model)
    {
        if (model is null)
        {
            return null;
        }

        return new ShippingDetailDto
        {
            Address = AddressPortableDto.CreateFromModel(model.Address),
            Name = NameDto.CreateFromModel(model.Name),
            Type = Helpers.ParseShippingTypeValue(model.Type)
        };
    }
}
