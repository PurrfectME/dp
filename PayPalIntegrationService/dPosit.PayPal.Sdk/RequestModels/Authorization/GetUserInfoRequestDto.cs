using dPosit.PayPal.Sdk.Api.Endpoints.Authorization.UserInfo;

namespace dPosit.PayPal.Sdk.RequestModels.Authorization;

public sealed class GetUserInfoRequestDto : AuthorizedRequestDto<GetUserInfoRequestDto>
{
    internal UserInfoRequest ToRequestModel()
    {
        Validate();

        return new UserInfoRequest
        {
            Jwt = Jwt,
            Schema = Constants.UserInfoSchemas.DEFAULT_SCHEMA
        };
    }
}
