using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class AddressDto
{
    /// <summary>
    /// The city name.
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// The country or region.
    /// </summary>
    public Country Country { get; set; }

    /// <summary>
    /// The first line of the address. For example, number or street.
    /// </summary>
    public string Line1 { get; set; }

    /// <summary>
    /// The second line of the address. For example, suite or apartment number.
    /// </summary>
    public string Line2 { get; set; }

    /// <summary>
    /// The postal code, which is the zip code or equivalent. Typically required for countries with a postal code or an equivalent.
    /// </summary>
    public string PostalCode { get; set; }

    /// <summary>
    /// The code for a US state or the equivalent for other countries. Required for transactions if the address is in one of these
    /// countries: Argentina, Brazil, Canada, China, India, Italy, Japan, Mexico, Thailand, or United States. Maximum length is
    /// 40 single-byte characters.
    /// </summary>
    public string State { get; set; }

    internal static AddressDto CreateFromModel(Address model)
    {
        if (model is null)
        {
            return null;
        }

        return new AddressDto
        {
            City = model.City,
            Country = Helpers.ParseCountryCodeValue(model.CountryCode),
            Line1 = model.Line1,
            Line2 = model.Line2,
            PostalCode = model.PostalCode,
            State = model.State
        };
    }
}
