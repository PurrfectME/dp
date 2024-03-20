using dPosit.PayPal.Sdk.Api.Endpoints.Orders.ConfirmOrder;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.RequestModels.Orders;

public sealed class ConfirmOrderRequestDto : AuthorizedRequestDto<ConfirmOrderRequestDto>
{
    /// <summary>
    /// The payment source definition.
    /// </summary>
    public PaymentSourceDto PaymentSource { get; set; }

    /// <summary>
    /// Customizes the payer confirmation experience.
    /// </summary>
    public OrderConfirmApplicationContextDto ApplicationContext { get; set; }

    /// <summary>
    /// The instruction to process an order.
    /// </summary>
    public ProcessingInstruction ProcessingInstruction { get; set; }

    protected override void Validate()
    {
        base.Validate();

        if (PaymentSource is null)
        {
            throw new PayPalModelValidationException<ConfirmOrderRequestDto>("PaymentSource is required.");
        }
    }

    internal ConfirmOrderRequest ToRequestModel()
    {
        Validate();

        return new ConfirmOrderRequest
        {
            Jwt = Jwt,
            PaymentSource = PaymentSource.ToRequestModel(),
            ApplicationContext = ApplicationContext?.ToRequestModel(),
            ProcessingInstruction = ProcessingInstruction.GetStringValue()
        };
    }
}
