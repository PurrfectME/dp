using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class Blik
{
    /// <summary>
    /// The two-character ISO 3166-1 <see cref="CountryAddressOptions.Code"/> that identifies the country or region.
    /// </summary>
    [JsonPropertyName("country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// The email address of the account holder associated with this payment method.
    /// </summary>
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>
    /// The name of the account holder associated with this payment method.
    /// </summary>
    [JsonPropertyName("name")]
    public Name Name { get; set; }
}
