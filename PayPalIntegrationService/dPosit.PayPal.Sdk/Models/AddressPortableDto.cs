using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class AddressPortableDto
{
    /// <summary>
    /// The country or region.
    /// </summary>
    public Country Country { get; set; }

    /// <summary>
    /// The first line of the address. For example, number or street. Required for data entry and compliance and risk checks. Must contain
    /// the full address.
    /// </summary>
    public string AddressLine1 { get; set; }

    /// <summary>
    /// The second line of the address. For example, suite or apartment number.
    /// </summary>
    public string AddressLine2 { get; set; }

    /// <summary>
    /// The highest level sub-division in a country, which is usually a province, state, or ISO-3166-2 subdivision. Format for postal
    /// delivery.
    /// </summary>
    /// <value>
    /// For UK - a county.<br/>
    /// For US - a state.<br/>
    /// For Canada - a province.<br/>
    /// For Japan - a prefecture.<br/>
    /// For Switzerland - a kanton.
    /// </value>
    /// <example>
    /// CA and not California.
    /// </example>
    public string AdminArea1 { get; set; }

    /// <summary>
    /// A city, town, or village. Smaller than <see cref="AdminArea1"/>
    /// </summary>
    public string AdminArea2 { get; set; }

    /// <summary>
    /// The postal code, which is the zip code or equivalent. Typically required for countries with a postal code or an equivalent.
    /// </summary>
    public string PostalCode { get; set; }

    private void Validate()
    {
        if (Country is Country.None)
        {
            throw new PayPalModelValidationException<AddressPortableDto>("Country is required.");
        }

        if (AddressLine1 is not null && AddressLine1.Length > 300)
        {
            throw new PayPalModelValidationException<AddressPortableDto>("Incorrect AddressLine1 lenght.");
        }

        if (AddressLine2 is not null && AddressLine2.Length > 300)
        {
            throw new PayPalModelValidationException<AddressPortableDto>("Incorrect AddressLine2 lenght.");
        }

        if (AdminArea1 is not null && AdminArea1.Length > 300)
        {
            throw new PayPalModelValidationException<AddressPortableDto>("Incorrect AdminArea1 lenght.");
        }

        if (AdminArea2 is not null && AdminArea2.Length > 120)
        {
            throw new PayPalModelValidationException<AddressPortableDto>("Incorrect AdminArea2 lenght.");
        }

        if (PostalCode is not null && PostalCode.Length > 60)
        {
            throw new PayPalModelValidationException<AddressPortableDto>("Incorrect PostalCode lenght.");
        }
    }

    internal AddressPortable ToRequestModel()
    {
        Validate();

        return new AddressPortable
        {
            CountryCode = Country.GetStringValue(),
            AddressLine1 = AddressLine1,
            AddressLine2 = AddressLine2,
            AdminArea1 = AdminArea1,
            AdminArea2 = AdminArea2,
            PostalCode = PostalCode
        };
    }

    internal static AddressPortableDto CreateFromModel(AddressPortable model)
    {
        if (model is null)
        {
            return null;
        }

        return new AddressPortableDto
        {
            Country = Helpers.ParseCountryCodeValue(model.CountryCode),
            AddressLine1 = model.AddressLine1,
            AddressLine2 = model.AddressLine2,
            AdminArea1 = model.AdminArea1,
            AdminArea2 = model.AdminArea2,
            PostalCode = model.PostalCode
        };
    }
}
