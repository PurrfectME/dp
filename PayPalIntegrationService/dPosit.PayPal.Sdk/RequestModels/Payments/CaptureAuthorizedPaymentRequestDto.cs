using dPosit.PayPal.Sdk.Api.Endpoints.Payments.CaptureAuthorizedPayment;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Models;

namespace dPosit.PayPal.Sdk.RequestModels.Payments;

public sealed class CaptureAuthorizedPaymentRequestDto : AuthorizedRequestDto<CaptureAuthorizedPaymentRequestDto>
{
    /// <summary>
    /// The amount to capture. To capture a portion of the full authorized amount, specify an amount. If amount is not specified, the full
    /// authorized amount is captured. The amount must be a positive number and in the same currency as the authorization against which
    /// the payment is being captured.
    /// </summary>
    public MoneyDto Amount { get; set; }

    /// <summary>
    /// Indicates whether you can make additional captures against the authorized payment.
    /// </summary>
    /// <value>
    /// <c>true</c> - if you do not intend to capture additional payments against the authorization.<br/>
    /// <c>false</c> - if you intend to capture additional payments against the authorization.
    /// </value>
    public bool? FinalCapture { get; set; }

    /// <summary>
    /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails
    /// that the payer receives.
    /// </summary>
    public string InvoiceId { get; set; }

    /// <summary>
    /// An informational note about this settlement. Appears in both the payer's transaction history and the emails that the payer receives.
    /// </summary>
    public string NoteToPayer { get; set; }

    /// <summary>
    /// Any additional payment instructions to be consider during payment processing. This processing instruction is applicable for
    /// Capturing an order or Authorizing an Order.
    /// </summary>
    public PaymentInstructionDto PaymentInstruction { get; set; }

    /// <summary>
    /// The payment descriptor on the payer's account statement.
    /// </summary>
    public string SoftDescriptor { get; set; }

    protected override void Validate()
    {
        base.Validate();

        if (InvoiceId is not null && InvoiceId.Length > 127)
        {
            throw new PayPalModelValidationException<CaptureAuthorizedPaymentRequestDto>("Incorrect InvoiceId lenght");
        }

        if (NoteToPayer is not null && NoteToPayer.Length > 255)
        {
            throw new PayPalModelValidationException<CaptureAuthorizedPaymentRequestDto>("Incorrect NoteToPayer lenght");
        }

        if (SoftDescriptor is not null && SoftDescriptor.Length > 22)
        {
            throw new PayPalModelValidationException<CaptureAuthorizedPaymentRequestDto>("Incorrect SoftDescriptor lenght");
        }
    }

    internal CaptureAuthorizedPaymentRequest ToRequestModel()
    {
        Validate();

        return new CaptureAuthorizedPaymentRequest
        {
            Jwt = Jwt,
            Amount = Amount?.ToRequestModel(),
            FinalCapture = FinalCapture,
            InvoiceId = InvoiceId,
            NoteToPayer = NoteToPayer,
            PaymentInstruction = PaymentInstruction?.ToRequestModel(),
            SoftDescriptor = SoftDescriptor
        };
    }
}
