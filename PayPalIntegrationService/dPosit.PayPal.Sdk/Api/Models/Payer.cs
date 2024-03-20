using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class Payer
{
    /// <summary>
    /// The email address of the payer.
    /// </summary>
    [JsonPropertyName("email_address")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// The PayPal-assigned ID for the payer.
    /// </summary>
    [JsonPropertyName("payer_id")]
    public string PayerId { get; set; }

    /// <summary>
    /// The address of the payer. Supports only the <c>address_line_1</c>, <c>address_line_2</c>, <c>admin_area_1</c>, <c>admin_area_2</c>,
    /// <c>postal_code</c>, and <c>country_code</c> properties. Also referred to as the billing address of the customer.
    /// </summary>
    [JsonPropertyName("address")]
    public AddressPortable Address { get; set; }

    /// <summary>
    /// The birth date of the payer in <c>YYYY-MM-DD</c> format.
    /// </summary>
    [JsonPropertyName("birth_date")]
    public string BirthDate { get; set; }

    /// <summary>
    /// The name of the payer. Supports only the <c>given_name</c> and <c>surname</c> properties.
    /// </summary>
    [JsonPropertyName("name")]
    public Name Name { get; set; }

    /// <summary>
    /// The phone number of the customer. Available only when you enable the <b>Contact Telephone Number</b> option in the
    /// <b>Profile & Settings</b> for the merchant's PayPal account. The <c>phone.phone_number</c> supports only <c>national_number</c>.
    /// </summary>
    [JsonPropertyName("phone")]
    public PhoneWithType Phone { get; set; }

    /// <summary>
    /// The tax information of the payer. Required only for Brazilian payer's. Both <c>tax_id</c> and <c>tax_id_type</c> are required.
    /// </summary>
    [JsonPropertyName("tax_info")]
    public TaxInfo TaxInfo { get; set; }
}
