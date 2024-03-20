using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class CardResponse
{
    /// <summary>
    /// Results of Authentication such as 3D Secure.
    /// </summary>
    [JsonPropertyName("authentication_result")]
    public AuthenticationResponse AuthenticationResult { get; set; }

    /// <summary>
    /// The billing address for this card. Supports only the <c>address_line_1</c>, <c>address_line_2</c>, <c>admin_area_1</c>,
    /// <c>admin_area_2</c>, <c>postal_code</c>, and <c>country_code</c> properties.
    /// </summary>
    [JsonPropertyName("billing_address")]
    public AddressPortable BillingAddress { get; set; }

    /// <summary>
    /// The card brand or network. Typically used in the response.
    /// </summary>
    /// <value>
    /// "VISA" - Visa card.<br/>
    /// "MASTERCARD" - Mastercard card.<br/>
    /// "DISCOVER" - Discover card.<br/>
    /// "AMEX" - American Express card.<br/>
    /// "SOLO" - Solo debit card.<br/>
    /// "JCB" - Japan Credit Bureau card.<br/>
    /// "STAR" - Military Star card.<br/>
    /// "DELTA" - Delta Airlines card.<br/>
    /// "SWITCH" - Switch credit card.<br/>
    /// "MAESTRO" - Maestro credit card.<br/>
    /// "CB_NATIONALE" - Carte Bancaire (CB) credit card.<br/>
    /// "CONFIGOGA" - Configoga credit card.<br/>
    /// "CONFIDIS" - Confidis credit card.<br/>
    /// "ELECTRON" - Visa Electron credit card.<br/>
    /// "CETELEM" - Cetelem credit card.<br/>
    /// "CHINA_UNION_PAY" - China union pay credit card.
    /// </value>
    [JsonPropertyName("brand")]
    public string Brand { get; set; }

    /// <summary>
    /// The last digits of the payment card.
    /// </summary>
    [JsonPropertyName("last_digits")]
    public string LastDigits { get; set; }

    /// <summary>
    /// The card holder's name as it appears on the card.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The payment card type.
    /// </summary>
    /// <value>
    /// "CREDIT" - a credit card.<br/>
    /// "DEBIT" - a debit card.<br/>
    /// "PREPAID" - a Prepaid card.<br/>
    /// "UNKNOWN" - card type cannot be determined.
    /// </value>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
