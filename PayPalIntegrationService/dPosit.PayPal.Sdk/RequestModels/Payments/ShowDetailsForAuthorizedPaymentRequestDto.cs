using dPosit.PayPal.Sdk.Api.Endpoints.Payments.ShowDetailsForAuthorizedPayment;

namespace dPosit.PayPal.Sdk.RequestModels.Payments;

public sealed class ShowDetailsForAuthorizedPaymentRequestDto : AuthorizedRequestDto<ShowDetailsForAuthorizedPaymentRequestDto>
{
    internal ShowDetailsForAuthorizedPaymentRequest ToRequestModel()
    {
        Validate();

        return new ShowDetailsForAuthorizedPaymentRequest
        {
            Jwt = Jwt
        };
    }
}
