using dPosit.PayPal.Sdk.Api.Endpoints.Orders.ShowOrderDetails;

namespace dPosit.PayPal.Sdk.RequestModels.Orders;

public sealed class ShowOrderDetailsRequestDto : AuthorizedRequestDto<ShowOrderDetailsRequestDto>
{
    internal ShowOrderDetailsRequest ToRequestModel()
    {
        Validate();

        return new ShowOrderDetailsRequest
        {
            Jwt = Jwt
        };
    }
}
