using dPosit.PayPal.Sdk.Api.Endpoints.Orders.UpdateOrder;
using dPosit.PayPal.Sdk.Models;

namespace dPosit.PayPal.Sdk.RequestModels.Orders;

public sealed class UpdateOrderRequestDto : AuthorizedRequestDto<UpdateOrderRequestDto>
{
    /// <summary>
    /// An array of JSON patch objects to apply partial updates to resources.
    /// </summary>
    public PatchDto<object>[] PatchRequest { get; set; } = {};

    internal UpdateOrderRequest ToRequestModel()
    {
        Validate();

        return new UpdateOrderRequest
        {
            Jwt = Jwt,
            PatchRequest = PatchRequest?.Select(patchOperation => patchOperation.ToRequestModel()).ToArray()
        };
    }
}
