using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class Address
{
    /// <summary>
    /// The city name.
    /// </summary>
    [JsonPropertyName("city")]
    public string City { get; set; }

    /// <summary>
    /// The two-character ISO 3166-1 <see cref="CountryAddressOptions.Code"/> that identifies the country or region.
    /// </summary>
    [JsonPropertyName("country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// The first line of the address. For example, number or street.
    /// </summary>
    [JsonPropertyName("line1")]
    public string Line1 { get; set; }

    /// <summary>
    /// The second line of the address. For example, suite or apartment number.
    /// </summary>
    [JsonPropertyName("line2")]
    public string Line2 { get; set; }

    /// <summary>
    /// The postal code, which is the zip code or equivalent. Typically required for countries with a postal code or an equivalent.
    /// </summary>
    [JsonPropertyName("postal_code")]
    public string PostalCode { get; set; }

    /// <summary>
    /// The code for a US state or the equivalent for other countries. Required for transactions if the address is in one of these
    /// countries: Argentina, Brazil, Canada, China, India, Italy, Japan, Mexico, Thailand, or United States. Maximum length is
    /// 40 single-byte characters.
    /// </summary>
    [JsonPropertyName("state")]
    public string State { get; set; }
}
