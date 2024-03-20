using dPosit.PayPal.Sdk.Api.Endpoints.Payments.CaptureAuthorizedPayment;
using dPosit.PayPal.Sdk.Models;

namespace dPosit.PayPal.Sdk.ResponseModels.Payments;

public sealed class CaptureAuthorizedPaymentResponseDto
{
    /// <summary>
    /// An object that provides supplementary/additional data related to a payment transaction.
    /// </summary>
    public SupplementaryDataDto SupplementaryData { get; set; }

    internal static CaptureAuthorizedPaymentResponseDto CreateFromModel(CaptureAuthorizedPaymentResponse model)
    {
        if (model is null)
        {
            return null;
        }

        return new CaptureAuthorizedPaymentResponseDto
        {
            SupplementaryData = SupplementaryDataDto.CreateFromModel(model.SupplementaryData)
        };
    }
}
