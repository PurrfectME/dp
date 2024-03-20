using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class AuthenticationResponseDto
{
    /// <summary>
    /// Liability shift indicator. The outcome of the issuer's authentication.
    /// </summary>
    public LiabilityShift LiabilityShift { get; set; }

    /// <summary>
    /// Results of 3D Secure Authentication.
    /// </summary>
    public ThreeDSecureAuthenticationResponseDto ThreeDSecure { get; set; }

    internal static AuthenticationResponseDto CreateFromModel(AuthenticationResponse model)
    {
        if (model is null)
        {
            return null;
        }

        return new AuthenticationResponseDto
        {
            LiabilityShift = Helpers.ParseLiabilityShiftValue(model.LiabilityShift),
            ThreeDSecure = ThreeDSecureAuthenticationResponseDto.CreateFromModel(model.ThreeDSecure)
        };
    }
}
