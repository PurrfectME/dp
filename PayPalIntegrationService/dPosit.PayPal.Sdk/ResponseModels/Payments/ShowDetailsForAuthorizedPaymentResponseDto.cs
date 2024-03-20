using dPosit.PayPal.Sdk.Api.Endpoints.Payments.ShowDetailsForAuthorizedPayment;
using dPosit.PayPal.Sdk.Models;

namespace dPosit.PayPal.Sdk.ResponseModels.Payments;

public sealed class ShowDetailsForAuthorizedPaymentResponseDto
{
    /// <summary>
    /// An object that provides supplementary/additional data related to a payment transaction.
    /// </summary>
    public SupplementaryDataDto SupplementaryData { get; set; }

    internal static ShowDetailsForAuthorizedPaymentResponseDto CreateFromModel(ShowDetailsForAuthorizedPaymentResponse model)
    {
        if (model is null)
        {
            return null;
        }

        return new ShowDetailsForAuthorizedPaymentResponseDto
        {
            SupplementaryData = SupplementaryDataDto.CreateFromModel(model.SupplementaryData)
        };
    }
}
