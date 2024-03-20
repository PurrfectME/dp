using dPosit.PayPal.Sdk.Api.Endpoints.Authorization.GenerateClientToken;

namespace dPosit.PayPal.Sdk.ResponseModels.Authorization;

public sealed class GenerateClientTokenResponseDto
{
    public string ClientToken { get; set; }

    public string IdToken { get; set; }

    public TimeSpan ExpiresIn { get; set; }

    internal static GenerateClientTokenResponseDto CreateFromModel(GenerateClientTokenResponse model)
    {
        if (model is null)
        {
            return null;
        }

        return new GenerateClientTokenResponseDto
        {
            ClientToken = model.ClientToken,
            IdToken = model.IdToken,
            ExpiresIn = TimeSpan.FromSeconds(model.ExpiresIn)
        };
    }
}
