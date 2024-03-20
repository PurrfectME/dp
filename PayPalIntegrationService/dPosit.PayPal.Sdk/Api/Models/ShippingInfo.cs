using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class ShippingInfo
{
    /// <summary>
    /// The shipping address that is associated with this order.
    /// </summary>
    [JsonPropertyName("address")]
    public Address Address { get; set; }

    /// <summary>
    /// The shipping method that is associated with this order.
    /// </summary>
    [JsonPropertyName("method")]
    public string Method { get; set; }

    /// <summary>
    /// The recipient's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The secondary shipping address that is associated with this order.
    /// </summary>
    [JsonPropertyName("secondary_shipping_address")]
    public Address SecondaryShippingAddress { get; set; }
}
