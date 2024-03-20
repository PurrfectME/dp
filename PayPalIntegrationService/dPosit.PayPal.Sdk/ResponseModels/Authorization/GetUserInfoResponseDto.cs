using dPosit.PayPal.Sdk.Api.Endpoints.Authorization.UserInfo;

namespace dPosit.PayPal.Sdk.ResponseModels.Authorization;

public sealed class GetUserInfoResponseDto
{
    public string UserId { get; set; }

    public string Sub { get; set; }

    internal static GetUserInfoResponseDto CreateFromModel(UserInfoResponse model)
    {
        if (model is null)
        {
            return null;
        }

        return new GetUserInfoResponseDto
        {
            UserId = model.UserId,
            Sub = model.Sub
        };
    }
}
