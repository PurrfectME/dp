using dPosit.PayPal.Sdk.Api.Endpoints.Orders.CapturePaymentForOrder;
using dPosit.PayPal.Sdk.Models;

namespace dPosit.PayPal.Sdk.RequestModels.Orders;

public sealed class CapturePaymentForOrderRequestDto : AuthorizedRequestDto<CapturePaymentForOrderRequestDto>
{
    /// <summary>
    /// The payment source definition.
    /// </summary>
    public PaymentSourceDto PaymentSource { get; set; }

    internal CapturePaymentForOrderRequest ToRequestModel()
    {
        Validate();

        return new CapturePaymentForOrderRequest
        {
            Jwt = Jwt,
            PaymentSource = PaymentSource?.ToRequestModel()
        };
    }
}
