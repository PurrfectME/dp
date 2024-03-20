using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class PhoneNumberDto
{
    /// <summary>
    /// The country calling code (CC), in its canonical international E.164 numbering plan format. The combined length of the CC and the
    /// national number must not be greater than 15 digits. The national number consists of a national destination code (NDC) and
    /// subscriber number (SN).
    /// </summary>
    public string CountryCode { get; set; }

    /// <summary>
    /// The national number, in its canonical international E.164 numbering plan format. The combined length of the country calling code
    /// (CC) and the national number must not be greater than 15 digits. The national number consists of a national destination code (NDC)
    /// and subscriber number (SN).
    /// </summary>
    public string NationalNumber { get; set; }

    /// <summary>
    /// The extension number.
    /// </summary>
    public string ExtensionNumber { get; set; }

    internal static PhoneNumberDto CreateFromModel(PhoneNumber model)
    {
        if (model is null)
        {
            return null;
        }

        return new PhoneNumberDto
        {
            CountryCode = model.CountryCode,
            NationalNumber = model.NationalNumber,
            ExtensionNumber = model.ExtensionNumber
        };
    }
}
