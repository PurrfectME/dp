using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class PayerInfo
{
    /// <summary>
    /// The PayPal` customer account ID.
    /// </summary>
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; }

    /// <summary>
    /// The payer address.
    /// </summary>
    [JsonPropertyName("address")]
    public Address Address { get; set; }

    /// <summary>
    /// The address status of the payer.
    /// </summary>
    /// <value>
    /// "Y" - Verified.
    /// "N" - Not verified.
    /// </value>
    [JsonPropertyName("address_status")]
    public string AddressStatus { get; set; }

    /// <summary>
    /// The two-character ISO 3166-1 <see cref="CountryAddressOptions.Code"/> that identifies the country or region.
    /// </summary>
    [JsonPropertyName("country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// The email address of the payer.
    /// </summary>
    [JsonPropertyName("email_address")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// The payer name.
    /// </summary>
    [JsonPropertyName("payer_name")]
    public Name PayerName { get; set; }

    /// <summary>
    /// The status of the payer.
    /// </summary>
    /// <value>
    /// "Y" - Verified.
    /// "N" - Not verified.
    /// </value>
    [JsonPropertyName("payer_status")]
    public string PayerStatus { get; set; }

    /// <summary>
    /// The primary phone number of the payer.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public PhoneNumber PhoneNumber { get; set; }
}
