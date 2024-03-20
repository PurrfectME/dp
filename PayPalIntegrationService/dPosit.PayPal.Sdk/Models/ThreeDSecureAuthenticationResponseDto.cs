using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class ThreeDSecureAuthenticationResponseDto
{
    /// <summary>
    /// The outcome of the issuer's authentication.
    /// </summary>
    public ThreeDSecureAuthenticationStatus AuthenticationStatus { get; set; }

    /// <summary>
    /// Status of authentication eligibility.
    /// </summary>
    public ThreeDSecureAuthenticationEligibilityStatus EnrollmentStatus { get; set; }

    internal static ThreeDSecureAuthenticationResponseDto CreateFromModel(ThreeDSecureAuthenticationResponse model)
    {
        if (model is null)
        {
            return null;
        }

        return new ThreeDSecureAuthenticationResponseDto
        {
            AuthenticationStatus = Helpers.ParseAuthenticationStatusValue(model.AuthenticationStatus),
            EnrollmentStatus = Helpers.ParseAuthenticationEligibilityStatusValue(model.EnrollmentStatus)
        };
    }
}
