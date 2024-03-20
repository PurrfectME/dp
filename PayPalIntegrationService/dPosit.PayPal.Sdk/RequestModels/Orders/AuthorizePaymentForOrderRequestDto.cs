using dPosit.PayPal.Sdk.Api.Endpoints.Orders.AuthorizePaymentForOrder;
using dPosit.PayPal.Sdk.Models;

namespace dPosit.PayPal.Sdk.RequestModels.Orders;

public sealed class AuthorizePaymentForOrderRequestDto : AuthorizedRequestDto<AuthorizePaymentForOrderRequestDto>
{
    /// <summary>
    /// The source of payment for the order, which can be a token or a card. Use this object only if you have not redirected the user after
    /// order creation to approve the payment. In such cases, the user-selected payment method in the PayPal flow is implicitly used.
    /// </summary>
    public PaymentSourceDto PaymentSource { get; set; }

    internal AuthorizePaymentForOrderRequest ToRequestModel()
    {
        Validate();

        return new AuthorizePaymentForOrderRequest
        {
            Jwt = Jwt,
            PaymentSource = PaymentSource?.ToRequestModel()
        };
    }
}
