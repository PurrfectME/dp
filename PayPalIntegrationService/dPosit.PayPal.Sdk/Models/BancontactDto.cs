using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class BancontactDto
{
    /// <summary>
    /// The business identification code (BIC). In payments systems, a BIC is used to identify a specific business, most commonly a bank.
    /// </summary>
    public string Bic { get; set; }

    /// <summary>
    /// The last digits of the card used to fund the Bancontact payment.
    /// </summary>
    public string CardLastDigits { get; set; }

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

    internal static BancontactDto CreateFromModel(Bancontact model)
    {
        if (model is null)
        {
            return null;
        }

        return new BancontactDto
        {
            Bic = model.Bic,
            CardLastDigits = model.CardLastDigits,
            Country = Helpers.ParseCountryCodeValue(model.CountryCode),
            IbanLastChars = model.IbanLastChars,
            Name = NameDto.CreateFromModel(model.Name)
        };
    }
}
