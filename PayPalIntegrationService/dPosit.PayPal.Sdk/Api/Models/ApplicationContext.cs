using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class ApplicationContext
{
    /// <summary>
    /// The label that overrides the business name in the PayPal account on the PayPal site.
    /// </summary>
    [JsonPropertyName("brand_name")]
    public string BrandName { get; set; }

    /// <summary>
    /// The URL where the customer is redirected after the customer cancels the payment.
    /// </summary>
    [JsonPropertyName("cancel_url")]
    public string CancelUrl { get; set; }

    /// <summary>
    /// The BCP 47-formatted locale of pages that the PayPal payment experience shows. PayPal supports a five-character code.
    /// </summary>
    /// <example>
    /// da-DK, he-IL, id-ID, ja-JP, no-NO, pt-BR, ru-RU, sv-SE, th-TH, zh-CN, zh-HK, or zh-TW
    /// </example>
    [JsonPropertyName("locale")]
    public string Locale { get; set; }

    /// <summary>
    /// The customer and merchant payment preferences.
    /// </summary>
    [JsonPropertyName("payment_method")]
    public PaymentMethod PaymentMethod { get; set; }

    /// <summary>
    /// The URL where the customer is redirected after the customer approves the payment.
    /// </summary>
    [JsonPropertyName("return_url")]
    public string ReturnUrl { get; set; }

    /// <summary>
    /// Configures a <b>Continue</b> or <b>Pay Now</b> checkout flow.
    /// </summary>
    /// <value>
    /// "CONTINUE" - after you redirect the customer to the PayPal payment page, a <b>Continue</b> button appears. Use this option when the
    /// final amount is not known when the checkout flow is initiated and you want to redirect the customer to the merchant page without
    /// processing the payment.<br/>
    /// "PAY_NOW" - after you redirect the customer to the PayPal payment page, a <b>Pay Now</b> button appears. Use this option when the
    /// final amount is known when the checkout is initiated and you want to process the payment immediately when the customer clicks
    /// <b>Pay Now</b>.
    /// </value>
    [JsonPropertyName("user_action")]
    public string UserAction { get; set; }
}
