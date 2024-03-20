using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class AuthorizationWithAdditionalDataDto
{
    /// <summary>
    /// The processor response for card transactions.
    /// </summary>
    public ProcessorResponseDto ProcessorResponse { get; set; }

    internal static AuthorizationWithAdditionalDataDto CreateFromModel(AuthorizationWithAdditionalData model)
    {
        if (model is null)
        {
            return null;
        }

        return new AuthorizationWithAdditionalDataDto
        {
            ProcessorResponse = ProcessorResponseDto.CreateFromModel(model.ProcessorResponse)
        };
    }
}
