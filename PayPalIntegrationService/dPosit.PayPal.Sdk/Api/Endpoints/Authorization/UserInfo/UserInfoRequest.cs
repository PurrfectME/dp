namespace dPosit.PayPal.Sdk.Api.Endpoints.Authorization.UserInfo;

internal sealed class UserInfoRequest : AuthorizedRequest
{
    /// <summary>
    /// Filters the response by a schema. Supported value is `paypalv1.1`.
    /// </summary>
    public string Schema { get; set; }
}
