using dPosit.PayPal.Sdk.Api.Endpoints.Payments.ReauthorizeAuthorizedPayment;
using dPosit.PayPal.Sdk.Models;

namespace dPosit.PayPal.Sdk.RequestModels.Payments;

public sealed class ReauthorizeAuthorizedPaymentRequestDto : AuthorizedRequestDto<ReauthorizeAuthorizedPaymentRequestDto>
{
    /// <summary>
    /// The amount to reauthorize for an authorized payment.
    /// </summary>
    public MoneyDto Amount { get; set; }

    internal ReauthorizeAuthorizedPaymentRequest ToRequestModel()
    {
        Validate();

        return new ReauthorizeAuthorizedPaymentRequest
        {
            Jwt = Jwt,
            Amount = Amount?.ToRequestModel()
        };
    }
}
