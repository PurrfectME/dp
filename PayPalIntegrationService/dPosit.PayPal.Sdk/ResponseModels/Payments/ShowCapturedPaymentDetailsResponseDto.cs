using dPosit.PayPal.Sdk.Api.Endpoints.Payments.ShowCapturedPaymentDetails;
using dPosit.PayPal.Sdk.Models;

namespace dPosit.PayPal.Sdk.ResponseModels.Payments;

public sealed class ShowCapturedPaymentDetailsResponseDto
{
    /// <summary>
    /// An object that provides supplementary/additional data related to a payment transaction.
    /// </summary>
    public SupplementaryDataDto SupplementaryData { get; set; }

    internal static ShowCapturedPaymentDetailsResponseDto CreateFromModel(ShowCapturedPaymentDetailsResponse model)
    {
        if (model is null)
        {
            return null;
        }

        return new ShowCapturedPaymentDetailsResponseDto
        {
            SupplementaryData = SupplementaryDataDto.CreateFromModel(model.SupplementaryData)
        };
    }
}
