using dPosit.PayPal.Sdk.Api.Endpoints.Payments.RefundCapturedPayment;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Models;

namespace dPosit.PayPal.Sdk.RequestModels.Payments;

public sealed class RefundCapturedPaymentRequestDto : AuthorizedRequestDto<RefundCapturedPaymentRequestDto>
{
    /// <summary>
    /// The amount to refund. To refund a portion of the captured amount, specify an amount. If amount is not specified, an amount equal
    /// to <c>captured amount - previous refunds</c> is refunded. The amount must be a positive number and in the same currency as the one
    /// in which the payment was captured.
    /// </summary>
    public MoneyDto Amount { get; set; }

    /// <summary>
    /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that
    /// the payer receives.
    /// </summary>
    public string InvoiceId { get; set; }

    /// <summary>
    /// The reason for the refund. Appears in both the payer's transaction history and the emails that the payer receives.
    /// </summary>
    public string NoteToPayer { get; set; }

    /// <summary>
    /// Any additional refund instructions to be set during refund payment processing. This object is only applicable to merchants that
    /// have been enabled for PayPal Commerce Platform for Marketplaces and Platforms capability. Please speak to your account manager if
    /// you want to use this capability.
    /// </summary>
    public PaymentInstructionDto PaymentInstruction { get; set; }

    protected override void Validate()
    {
        base.Validate();

        if (InvoiceId is not null && InvoiceId.Length > 127)
        {
            throw new PayPalModelValidationException<RefundCapturedPaymentRequestDto>("Incorrect InvoiceId lenght");
        }

        if (NoteToPayer is not null && NoteToPayer.Length > 255)
        {
            throw new PayPalModelValidationException<RefundCapturedPaymentRequestDto>("Incorrect NoteToPayer lenght");
        }
    }

    internal RefundCapturedPaymentRequest ToRequestModel()
    {
        Validate();

        return new RefundCapturedPaymentRequest
        {
            Jwt = Jwt,
            Amount = Amount?.ToRequestModel(),
            InvoiceId = InvoiceId,
            NoteToPayer = NoteToPayer,
            PaymentInstruction = PaymentInstruction?.ToRequestModel()
        };
    }
}
