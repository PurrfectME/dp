using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class CheckoutOption
{
    /// <summary>
    /// The checkout option name, such as <c>color</c> or <c>texture</c>.
    /// </summary>
    [JsonPropertyName("checkout_option_name")]
    public string CheckoutOptionName { get; set; }

    /// <summary>
    /// The checkout option value. For example, the checkout option <c>color</c> might be <c>blue</c> or <c>red</c> while the checkout
    /// option <c>texture</c> might be <c>smooth</c> or <c>rippled</c>.
    /// </summary>
    [JsonPropertyName("checkout_option_value")]
    public string CheckoutOptionValue { get; set; }
}
