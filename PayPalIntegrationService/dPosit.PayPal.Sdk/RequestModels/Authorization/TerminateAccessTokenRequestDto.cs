using dPosit.PayPal.Sdk.Api.Endpoints.Authorization.TerminateAccessToken;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.RequestModels.Authorization;

public sealed class TerminateAccessTokenRequestDto : AuthorizedRequestDto<TerminateAccessTokenRequestDto>
{
    /// <summary>
    /// The token to get revoked.
    /// </summary>
    public string Token { get; set; }

    /// <summary>
    /// A hint about the type of the token submitted for revocation.
    /// </summary>
    /// <value>
    /// <c>TokenTypeHint.AccessToken</c> - to terminate access token.<br/>
    /// <c>TokenTypeHint.RefreshToken</c> - to terminate refresh token.
    /// </value>
    public TokenTypeHint TokenTypeHint { get; set; }

    /// <summary>
    /// Type of credentials for authorization to initiate token termination.
    /// </summary>
    /// <value>
    /// <c>GrantType.ClientCredentials</c> - use credentials to get access token.<br/>
    /// <c>GrantType.RefreshToken</c> - use refresh token to get access token.<br/>
    /// <c>GrantType.AuthorizationCode</c> - use authorization code to get access token.
    /// </value>
    public GrantType GrantType { get; set; }

    /// <summary>
    /// The refresh token to get access token for call with <c>GrantType.RefreshToken</c>
    /// </summary>
    public string RefreshToken { get; set; }

    /// <summary>
    /// The authorization code to get access token for call with <c>GrantType.AuthorizationCode</c>
    /// </summary>
    public string Code { get; set; }

    protected override void Validate()
    {
        base.Validate();

        if (string.IsNullOrWhiteSpace(Token))
        {
            throw new PayPalModelValidationException<TerminateAccessTokenRequestDto>("Token is required.");
        }

        switch (GrantType)
        {
            case GrantType.None:
                throw new PayPalModelValidationException<TerminateAccessTokenRequestDto>("Missing GrantType.");
            case GrantType.RefreshToken:
                if (string.IsNullOrWhiteSpace(RefreshToken))
                {
                    throw new PayPalModelValidationException<TerminateAccessTokenRequestDto>(
                        "Missing RefreshToken for GrantType.RefreshToken.");
                }
                break;
            case GrantType.AuthorizationCode:
                if (string.IsNullOrWhiteSpace(Code))
                {
                    throw new PayPalModelValidationException<TerminateAccessTokenRequestDto>(
                        "Missing Code for GrantType.AuthorizationCode.");
                }
                break;
        }
    }

    internal TerminateAccessTokenRequest ToRequestModel()
    {
        Validate();

        return new TerminateAccessTokenRequest
        {
            Jwt = Jwt,
            Token = Token,
            TokenTypeHint = TokenTypeHint.GetStringValue(),
            GrantType = GrantType.GetStringValue(),
            RefreshToken = RefreshToken,
            Code = Code
        };
    }
}
