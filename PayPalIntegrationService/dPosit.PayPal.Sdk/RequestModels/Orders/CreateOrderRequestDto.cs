using dPosit.PayPal.Sdk.Api.Endpoints.Orders.CreateOrder;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.RequestModels.Orders;

public sealed class CreateOrderRequestDto
{
    /// <summary>
    /// Jwt access token.
    /// </summary>
    public string Jwt { get; set; }

    /// <summary>
    /// The intent to either capture payment immediately or authorize a payment for an order after order creation.
    /// </summary>
    public Intent Intent { get; set; }

    /// <summary>
    /// An array of purchase units. Each purchase unit establishes a contract between a payer and the payee. Each purchase unit represents
    /// either a full or partial order that the payer intends to purchase from the payee.
    /// </summary>
    public PurchaseUnitRequestDto[] PurchaseUnits { get; set; }

    /// <summary>
    /// Customize the payer experience during the approval process for the payment with PayPal.
    /// </summary>
    public ApplicationContextDto ApplicationContext { get; set; }

    private void Validate()
    {
        if (string.IsNullOrWhiteSpace(Jwt))
        {
            throw new PayPalModelValidationException<CreateOrderRequestDto>("Jwt can not be empty.");
        }

        if (Intent is Intent.None)
        {
            throw new PayPalModelValidationException<CreateOrderRequestDto>("Intent is required.");
        }

        if (PurchaseUnits is null || PurchaseUnits.Length is 0)
        {
            throw new PayPalModelValidationException<CreateOrderRequestDto>("PurchaseUnits can not be empty.");
        }
    }

    internal CreateOrderRequest ToRequestModel()
    {
        Validate();

        return new CreateOrderRequest
        {
            Jwt = Jwt,
            Intent = Intent.GetStringValue(),
            PurchaseUnits = PurchaseUnits.Select(unit => unit.ToRequestModel()).ToArray(),
            ApplicationContext = ApplicationContext?.ToRequestModel()
        };
    }
}
