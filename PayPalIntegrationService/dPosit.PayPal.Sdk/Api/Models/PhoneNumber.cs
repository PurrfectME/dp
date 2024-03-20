using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class PhoneNumber
{
    /// <summary>
    /// The country calling code (CC), in its canonical international E.164 numbering plan format. The combined length of the CC and the
    /// national number must not be greater than 15 digits. The national number consists of a national destination code (NDC) and
    /// subscriber number (SN).
    /// </summary>
    [JsonPropertyName("country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// The national number, in its canonical international E.164 numbering plan format. The combined length of the country calling code
    /// (CC) and the national number must not be greater than 15 digits. The national number consists of a national destination code (NDC)
    /// and subscriber number (SN).
    /// </summary>
    [JsonPropertyName("national_number")]
    public string NationalNumber { get; set; }

    /// <summary>
    /// The extension number.
    /// </summary>
    [JsonPropertyName("extension_number")]
    public string ExtensionNumber { get; set; }
}
