using dPosit.PayPal.Sdk.Api.Endpoints.Authorization.GenerateClientToken;

namespace dPosit.PayPal.Sdk.RequestModels.Authorization;

public sealed class GenerateClientTokenRequestDto : AuthorizedRequestDto<GenerateClientTokenRequestDto>
{
    /// <summary>
    /// The customer-specific id associated with the client token.
    /// </summary>
    public string CustomerId { get; set; }

    internal GenerateClientTokenRequest ToRequestModel()
    {
        Validate();

        return new GenerateClientTokenRequest
        {
            Jwt = Jwt,
            CustomerId = CustomerId
        };
    }
}
