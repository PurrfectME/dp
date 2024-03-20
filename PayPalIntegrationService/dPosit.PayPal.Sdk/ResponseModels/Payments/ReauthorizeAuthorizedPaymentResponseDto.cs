using dPosit.PayPal.Sdk.Api.Endpoints.Payments.ReauthorizeAuthorizedPayment;
using dPosit.PayPal.Sdk.Models;

namespace dPosit.PayPal.Sdk.ResponseModels.Payments;

public sealed class ReauthorizeAuthorizedPaymentResponseDto
{
    /// <summary>
    /// An object that provides supplementary/additional data related to a payment transaction.
    /// </summary>
    public SupplementaryDataDto SupplementaryData { get; set; }

    internal static ReauthorizeAuthorizedPaymentResponseDto CreateFromModel(ReauthorizeAuthorizedPaymentResponse model)
    {
        if (model is null)
        {
            return null;
        }

        return new ReauthorizeAuthorizedPaymentResponseDto
        {
            SupplementaryData = SupplementaryDataDto.CreateFromModel(model.SupplementaryData)
        };
    }
}
