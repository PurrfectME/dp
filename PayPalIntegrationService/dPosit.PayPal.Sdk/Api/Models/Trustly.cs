using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class Trustly
{
    /// <summary>
    /// The business identification code (BIC). In payments systems, a BIC is used to identify a specific business, most commonly a bank.
    /// </summary>
    [JsonPropertyName("bic")]
    public string Bic { get; set; }

    /// <summary>
    /// The two-character ISO 3166-1 <see cref="CountryAddressOptions.Code"/> that identifies the country or region.
    /// </summary>
    [JsonPropertyName("country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// The last characters of the IBAN used to pay.
    /// </summary>
    [JsonPropertyName("iban_last_chars")]
    public string IbanLastChars { get; set; }

    /// <summary>
    /// The name of the account holder associated with this payment method.
    /// </summary>
    [JsonPropertyName("name")]
    public Name Name { get; set; }
}
