using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class GiropayDto
{
    /// <summary>
    /// The business identification code (BIC). In payments systems, a BIC is used to identify a specific business, most commonly a bank.
    /// </summary>
    public string Bic { get; set; }

    /// <summary>
    /// The country or region.
    /// </summary>
    public Country Country { get; set; }

    /// <summary>
    /// The name of the account holder associated with this payment method.
    /// </summary>
    public NameDto Name { get; set; }

    internal static GiropayDto CreateFromModel(Giropay model)
    {
        if (model is null)
        {
            return null;
        }

        return new GiropayDto
        {
            Bic = model.Bic,
            Country = Helpers.ParseCountryCodeValue(model.CountryCode),
            Name = NameDto.CreateFromModel(model.Name)
        };
    }
}
