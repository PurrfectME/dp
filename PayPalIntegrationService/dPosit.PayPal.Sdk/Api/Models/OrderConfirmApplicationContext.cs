using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class OrderConfirmApplicationContext
{
    /// <summary>
    /// Label to present to your payer as part of the PayPal hosted web experience.
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
    /// The URL where the customer is redirected after the customer approves the payment.
    /// </summary>
    [JsonPropertyName("return_url")]
    public string ReturnUrl { get; set; }

    /// <summary>
    /// Provides additional details to process a payment using a <c>payment_source</c> that has been stored or is intended to be stored
    /// (also referred to as stored_credential or card-on-file).
    /// </summary>
    /// <remarks>
    /// Parameter compatibility:<br/>
    /// <c>payment_type=ONE_TIME</c> is compatible only with <c>payment_initiator=CUSTOMER</c>.<br/><br/>
    /// <c>usage=FIRST</c> is compatible only with <c>payment_initiator=CUSTOMER</c>.<br/><br/>
    /// <c>previous_transaction_reference</c> or <c>previous_network_transaction_reference</c> is compatible only with
    /// <c>payment_initiator=MERCHANT</c>.<br/><br/>
    /// Only one of the parameters - <c>previous_transaction_reference</c> and <c>previous_network_transaction_reference</c> - can be present
    /// in the request.
    /// </remarks>
    [JsonPropertyName("stored_payment_source")]
    public StoredPaymentSource StoredPaymentSource { get; set; }
}
