using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class RelatedIdsDto
{
    /// <summary>
    /// Authorization ID related to the resource.
    /// </summary>
    public string AuthorizationId { get; set; }

    /// <summary>
    /// Capture ID related to the resource.
    /// </summary>
    public string CaptureId { get; set; }

    /// <summary>
    /// Order ID related to the resource.
    /// </summary>
    public string OrderId { get; set; }

    internal static RelatedIdsDto CreateFromModel(RelatedIds model)
    {
        if (model is null)
        {
            return null;
        }

        return new RelatedIdsDto
        {
            AuthorizationId = model.AuthorizationId,
            CaptureId = model.CaptureId,
            OrderId = model.OrderId
        };
    }
}
