using dPosit.PayPal.Sdk.Api.Endpoints.Payments.ShowRefundDetails;

namespace dPosit.PayPal.Sdk.RequestModels.Payments;

public sealed class ShowRefundDetailsRequestDto : AuthorizedRequestDto<ShowRefundDetailsRequestDto>
{
    internal ShowRefundDetailsRequest ToRequestModel()
    {
        Validate();

        return new ShowRefundDetailsRequest
        {
            Jwt = Jwt
        };
    }
}
