using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class ShippingInfoDto
{
    /// <summary>
    /// The shipping address that is associated with this order.
    /// </summary>
    public AddressDto Address { get; set; }

    /// <summary>
    /// The shipping method that is associated with this order.
    /// </summary>
    public string Method { get; set; }

    /// <summary>
    /// The recipient's name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The secondary shipping address that is associated with this order.
    /// </summary>
    public AddressDto SecondaryShippingAddress { get; set; }

    internal static ShippingInfoDto CreateFromModel(ShippingInfo model)
    {
        if (model is null)
        {
            return null;
        }

        return new ShippingInfoDto
        {
            Address = AddressDto.CreateFromModel(model.Address),
            Method = model.Method,
            Name = model.Name,
            SecondaryShippingAddress = AddressDto.CreateFromModel(model.SecondaryShippingAddress)
        };
    }
}
