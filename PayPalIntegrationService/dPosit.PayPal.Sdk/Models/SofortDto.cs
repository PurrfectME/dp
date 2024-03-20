using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class SofortDto
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
    /// The last characters of the IBAN used to pay.
    /// </summary>
    public string IbanLastChars { get; set; }

    /// <summary>
    /// The name of the account holder associated with this payment method.
    /// </summary>
    public NameDto Name { get; set; }

    internal static SofortDto CreateFromModel(Sofort model)
    {
        if (model is null)
        {
            return null;
        }

        return new SofortDto
        {
            Bic = model.Bic,
            Country = Helpers.ParseCountryCodeValue(model.CountryCode),
            IbanLastChars = model.IbanLastChars,
            Name = NameDto.CreateFromModel(model.Name)
        };
    }
}
