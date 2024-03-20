using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class BlikDto
{
    /// <summary>
    /// The country or region.
    /// </summary>
    public Country Country { get; set; }

    /// <summary>
    /// The email address of the account holder associated with this payment method.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// The name of the account holder associated with this payment method.
    /// </summary>
    public NameDto Name { get; set; }

    internal static BlikDto CreateFromModel(Blik model)
    {
        if (model is null)
        {
            return null;
        }

        return new BlikDto
        {
            Country = Helpers.ParseCountryCodeValue(model.CountryCode),
            Email = model.Email,
            Name = NameDto.CreateFromModel(model.Name)
        };
    }
}
