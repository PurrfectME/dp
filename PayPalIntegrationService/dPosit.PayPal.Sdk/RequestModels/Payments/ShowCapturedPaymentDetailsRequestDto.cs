using dPosit.PayPal.Sdk.Api.Endpoints.Payments.ShowCapturedPaymentDetails;

namespace dPosit.PayPal.Sdk.RequestModels.Payments;

public sealed class ShowCapturedPaymentDetailsRequestDto : AuthorizedRequestDto<ShowCapturedPaymentDetailsRequestDto>
{
    internal ShowCapturedPaymentDetailsRequest ToRequestModel()
    {
        Validate();

        return new ShowCapturedPaymentDetailsRequest
        {
            Jwt = Jwt
        };
    }
}
