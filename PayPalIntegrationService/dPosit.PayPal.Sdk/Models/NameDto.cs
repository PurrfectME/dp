using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Exceptions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class NameDto
{
    /// <summary>
    /// When the party is a person, the party's full name.
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// When the party is a person, the party's given, or first, name.
    /// </summary>
    public string GiverName { get; set; }

    /// <summary>
    /// When the party is a person, the party's middle name. Use also to store multiple middle names including the patronymic, or father's,
    /// middle name.
    /// </summary>
    public string MiddleName { get; set; }

    /// <summary>
    /// The prefix, or title, to the party's name.
    /// </summary>
    public string Prefix { get; set; }

    /// <summary>
    /// The suffix for the party's name.
    /// </summary>
    public string Suffix { get; set; }

    /// <summary>
    /// When the party is a person, the party's surname or family name. Also known as the last name. Required when the party is a person.
    /// Use also to store multiple surnames including the matronymic, or mother's, surname.
    /// </summary>
    public string Surname { get; set; }

    private void Validate()
    {
        if (FullName is not null && FullName.Length > 300)
        {
            throw new PayPalModelValidationException<NameDto>("Incorrect FullName lenght.");
        }
        if (GiverName is not null && GiverName.Length > 140)
        {
            throw new PayPalModelValidationException<NameDto>("Incorrect GiverName lenght.");
        }
        if (MiddleName is not null && MiddleName.Length > 140)
        {
            throw new PayPalModelValidationException<NameDto>("Incorrect MiddleName lenght.");
        }
        if (Prefix is not null && Prefix.Length > 140)
        {
            throw new PayPalModelValidationException<NameDto>("Incorrect Prefix lenght.");
        }
        if (Suffix is not null && Suffix.Length > 140)
        {
            throw new PayPalModelValidationException<NameDto>("Incorrect Suffix lenght.");
        }
        if (Surname is not null && Surname.Length > 140)
        {
            throw new PayPalModelValidationException<NameDto>("Incorrect Surname lenght.");
        }
    }

    internal Name ToRequestModel()
    {
        Validate();

        return new Name
        {
            FullName = FullName,
            GiverName = GiverName,
            MiddleName = MiddleName,
            Prefix = Prefix,
            Suffix = Suffix
        };
    }

    internal static NameDto CreateFromModel(Name model)
    {
        if (model is null)
        {
            return null;
        }

        return new NameDto
        {
            FullName = model.FullName,
            GiverName = model.GiverName,
            MiddleName = model.MiddleName,
            Prefix = model.Prefix,
            Suffix = model.Suffix,
            Surname = model.Surname
        };
    }
}
