using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class CheckoutOptionDto
{
    /// <summary>
    /// The checkout option name, such as <c>color</c> or <c>texture</c>.
    /// </summary>
    public string CheckoutOptionName { get; set; }

    /// <summary>
    /// The checkout option value. For example, the checkout option <c>color</c> might be <c>blue</c> or <c>red</c> while the checkout
    /// option <c>texture</c> might be <c>smooth</c> or <c>rippled</c>.
    /// </summary>
    public string CheckoutOptionValue { get; set; }

    internal static CheckoutOptionDto CreateFromModel(CheckoutOption model)
    {
        if (model is null)
        {
            return null;
        }

        return new CheckoutOptionDto
        {
            CheckoutOptionName = model.CheckoutOptionName,
            CheckoutOptionValue = model.CheckoutOptionName
        };
    }
}
