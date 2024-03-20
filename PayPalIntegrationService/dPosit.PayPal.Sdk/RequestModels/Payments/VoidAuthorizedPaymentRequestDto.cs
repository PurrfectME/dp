using dPosit.PayPal.Sdk.Api.Endpoints.Payments.VoidAuthorizedPayment;

namespace dPosit.PayPal.Sdk.RequestModels.Payments;

public sealed class VoidAuthorizedPaymentRequestDto : AuthorizedRequestDto<VoidAuthorizedPaymentRequestDto>
{
    internal VoidAuthorizedPaymentRequest ToRequestModel()
    {
        Validate();

        return new VoidAuthorizedPaymentRequest
        {
            Jwt = Jwt
        };
    }
}
