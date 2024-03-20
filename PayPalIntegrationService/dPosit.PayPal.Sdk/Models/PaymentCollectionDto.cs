using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class PaymentCollectionDto
{
    /// <summary>
    /// An array of authorized payments for a purchase unit. A purchase unit can have zero or more authorized payments.
    /// </summary>
    public AuthorizationWithAdditionalDataDto[] Authorizations { get; set; }

    /// <summary>
    /// An array of captured payments for a purchase unit. A purchase unit can have zero or more captured payments.
    /// </summary>
    public CaptureDto[] Captures { get; set; }

    /// <summary>
    /// An array of refunds for a purchase unit. A purchase unit can have zero or more refunds.
    /// </summary>
    public RefundDto[] Refunds { get; set; }

    internal static PaymentCollectionDto CreateFromModel(PaymentCollection model)
    {
        if (model is null)
        {
            return null;
        }

        return new PaymentCollectionDto
        {
            Authorizations = model.Authorizations?.Select(AuthorizationWithAdditionalDataDto.CreateFromModel).ToArray(),
            Captures = model.Captures?.Select(CaptureDto.CreateFromModel).ToArray(),
            Refunds = model.Refunds?.Select(RefundDto.CreateFromModel).ToArray()
        };
    }
}
