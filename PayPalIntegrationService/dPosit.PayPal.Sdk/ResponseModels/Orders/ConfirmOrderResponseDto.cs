using dPosit.PayPal.Sdk.Api.Endpoints.Orders.ConfirmOrder;
using dPosit.PayPal.Sdk.Extensions;
using dPosit.PayPal.Sdk.Models;

namespace dPosit.PayPal.Sdk.ResponseModels.Orders;

public sealed class ConfirmOrderResponseDto
{
    /// <summary>
    /// The date and time when the transaction occurred, in Internet date and time format. Seconds are required while fractional seconds
    /// are optional.
    /// </summary>
    public DateTimeOffset CreateTime { get; set; }

    /// <summary>
    /// The ID of the order.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// The intent to either capture payment immediately or authorize a payment for an order after order creation.
    /// </summary>
    public Intent Intent { get; set; }

    /// <summary>
    /// An array of request-related HATEOAS links. To complete payer <c>approval</c>, use the approve link to redirect the payer. The API
    /// caller has 3 hours (default setting, this which can be changed by your account manager to 24/48/72 hours to accommodate your use
    /// case) from the time the order is created, to redirect your payer. Once redirected, the API caller has 3 hours for the payer to
    /// approve the order and either authorize or capture the order. If you are not using the PayPal JavaScript SDK to initiate PayPal
    /// Checkout (in context) ensure that you include <c>application_context.return_url</c> is specified or you will get "We're sorry,
    /// Things don't appear to be working at the moment" after the payer approves the payment.
    /// </summary>
    public LinkDescriptionDto[] Links { get; set; }

    /// <summary>
    /// The payment source used to fund the payment.
    /// </summary>
    public PaymentSourceResponseDto PaymentSource { get; set; }

    /// <summary>
    /// The instruction to process an order.
    /// </summary>
    public ProcessingInstruction ProcessingInstruction { get; set; }

    /// <summary>
    /// An array of purchase units. Each purchase unit establishes a contract between a customer and merchant. Each purchase unit represents
    /// either a full or partial order that the customer intends to purchase from the merchant.
    /// </summary>
    public PurchaseUnitDto[] PurchaseUnits { get; set; }

    /// <summary>
    /// The order status.
    /// </summary>
    public OrderStatus Status { get; set; }

    /// <summary>
    /// The date and time when the transaction was last updated, in Internet date and time format. Seconds are required while fractional
    /// seconds are optional.
    /// </summary>
    public DateTimeOffset? UpdateTime { get; set; }

    internal static ConfirmOrderResponseDto CreateFromModel(ConfirmOrderResponse model)
    {
        return new ConfirmOrderResponseDto
        {
            CreateTime = DateTimeOffset.Parse(model.CreateTime),
            Id = model.Id,
            Intent = Helpers.ParseIntentValue(model.Intent),
            Links = model.Links?.Select(LinkDescriptionDto.CreateFromModel).ToArray(),
            PaymentSource = PaymentSourceResponseDto.CreateFromModel(model.PaymentSource),
            ProcessingInstruction = Helpers.ParseProcessingInstructionValue(model.ProcessingInstruction),
            PurchaseUnits = model.PurchaseUnits?.Select(PurchaseUnitDto.CreateFromModel).ToArray(),
            Status = Helpers.ParseOrderStatusValue(model.Status),
            UpdateTime = model.UpdateTime is not null ? DateTimeOffset.Parse(model.UpdateTime) : null
        };
    }
}
