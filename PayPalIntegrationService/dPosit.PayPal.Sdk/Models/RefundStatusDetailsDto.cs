using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class RefundStatusDetailsDto
{
    /// <summary>
    /// The reason why the refund has the <c>PENDING</c> or <c>FAILED</c> status.
    /// </summary>
    public RefundStatusReason Reason { get; set; }

    internal static RefundStatusDetailsDto CreateFromModel(RefundStatusDetails model)
    {
        if (model is null)
        {
            return null;
        }

        return new RefundStatusDetailsDto
        {
            Reason = Helpers.ParseRefundStatusReasonValue(model.Reason)
        };
    }
}
