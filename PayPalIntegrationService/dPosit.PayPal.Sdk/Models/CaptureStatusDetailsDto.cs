using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class CaptureStatusDetailsDto
{
    /// <summary>
    /// The reason why the captured payment status is <c>PENDING</c> or <c>DENIED</c>.
    /// </summary>
    public CaptureStatusReason Reason { get; set; }

    internal static CaptureStatusDetailsDto CreateFromModel(CaptureStatusDetails model)
    {
        if (model is null)
        {
            return null;
        }

        return new CaptureStatusDetailsDto
        {
            Reason = Helpers.ParseCaptureStatusReasonValue(model.Reason)
        };
    }
}
