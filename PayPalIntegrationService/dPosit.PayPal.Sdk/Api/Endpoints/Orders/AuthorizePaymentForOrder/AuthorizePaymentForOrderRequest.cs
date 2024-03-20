using System.Text.Json.Serialization;
using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Api.Endpoints.Orders.AuthorizePaymentForOrder;

internal sealed class AuthorizePaymentForOrderRequest : AuthorizedRequest
{
    /// <summary>
    /// The source of payment for the order, which can be a token or a card. Use this object only if you have not redirected the user after
    /// order creation to approve the payment. In such cases, the user-selected payment method in the PayPal flow is implicitly used.
    /// </summary>
    [JsonPropertyName("payment_source")]
    public PaymentSource PaymentSource { get; set; }
}
