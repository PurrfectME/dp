using dPosit.PayPal.Sdk.Api.Endpoints.Authorization.GenerateAccessToken;
using dPosit.PayPal.Sdk.Extensions;
using dPosit.PayPal.Sdk.Models;

namespace dPosit.PayPal.Sdk.ResponseModels.Authorization;

public sealed class GenerateAccessTokenResponseDto
{
    public string[] Scopes { get; set; }

    public string AccessToken { get; set; }

    public TokenType TokenType { get; set; }

    public string AppId { get; set; }

    public TimeSpan ExpiresIn { get; set; }

    public AuthenticationScheme[] SupportedAuthnSchemes { get; set; }

    public string Nonce { get; set; }

    public ClientMetadataDto ClientMetadata { get; set; }

    internal static GenerateAccessTokenResponseDto CreateFromModel(GenerateAccessTokenResponse model)
    {
        if (model is null)
        {
            return null;
        }

        return new GenerateAccessTokenResponseDto
        {
            Scopes = model.Scope.Split(' '),
            AccessToken = model.AccessToken,
            TokenType = Helpers.ParseTokenTypeValue(model.TokenType),
            AppId = model.AppId,
            ExpiresIn = TimeSpan.FromSeconds(model.ExpiresIn),
            SupportedAuthnSchemes = model.SupportedAuthnSchemes.Select(Helpers.ParseAuthenticationSchemeValue).ToArray(),
            Nonce = model.Nonce,
            ClientMetadata = new ClientMetadataDto
            {
                Name = model.ClientMetadata.Name,
                DisplayName = model.ClientMetadata.DisplayName,
                LogoUri = model.ClientMetadata.LogoUri,
                Scopes = model.ClientMetadata.Scopes,
                UiType = model.ClientMetadata.UiType
            }
        };
    }
}
