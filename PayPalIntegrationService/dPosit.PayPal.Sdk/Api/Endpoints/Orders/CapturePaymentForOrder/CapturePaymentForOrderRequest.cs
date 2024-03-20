using System.Text.Json.Serialization;
using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Api.Endpoints.Orders.CapturePaymentForOrder;

internal sealed class CapturePaymentForOrderRequest : AuthorizedRequest
{
    /// <summary>
    /// The payment source definition.
    /// </summary>
    [JsonPropertyName("payment_source")]
    public PaymentSource PaymentSource { get; set; }
}
