using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class AddressPortable
{
    /// <summary>
    /// The two-character ISO 3166-1 <see cref="CountryAddressOptions.Code"/> that identifies the country or region.
    /// </summary>
    [JsonPropertyName("country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// The first line of the address. For example, number or street. Required for data entry and compliance and risk checks. Must contain
    /// the full address.
    /// </summary>
    [JsonPropertyName("address_line_1")]
    public string AddressLine1 { get; set; }

    /// <summary>
    /// The second line of the address. For example, suite or apartment number.
    /// </summary>
    [JsonPropertyName("address_line_2")]
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
    [JsonPropertyName("admin_area_1")]
    public string AdminArea1 { get; set; }

    /// <summary>
    /// A city, town, or village. Smaller than <see cref="AdminArea1"/>
    /// </summary>
    [JsonPropertyName("admin_area_2")]
    public string AdminArea2 { get; set; }

    /// <summary>
    /// The postal code, which is the zip code or equivalent. Typically required for countries with a postal code or an equivalent.
    /// </summary>
    [JsonPropertyName("postal_code")]
    public string PostalCode { get; set; }
}
