using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class ShippingDetail
{
    /// <summary>
    /// The address of the person to whom to ship the items. Supports only the <c>address_line_1</c>, <c>address_line_2</c>,
    /// <c>admin_area_1</c>, <c>admin_area_2</c>, <c>postal_code</c>, and <c>country_code</c> properties.
    /// </summary>
    [JsonPropertyName("address")]
    public AddressPortable Address { get; set; }

    /// <summary>
    /// The name of the person to whom to ship the items. Supports only the <c>full_name</c> property.
    /// </summary>
    [JsonPropertyName("name")]
    public Name Name { get; set; }

    /// <summary>
    /// The method by which the payer wants to get their items from the payee e.g shipping, in-person pickup. Either type or options but
    /// not both may be present.
    /// </summary>
    /// <value>
    /// "SHIPPING" - the payer intends to receive the items at a specified address.<br/>
    /// "PICKUP_IN_PERSON" - the payer intends to pick up the items from the payee in person.
    /// </value>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
