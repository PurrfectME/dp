using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class StoredPaymentSourceDto
{
    /// <summary>
    /// The person or party who initiated or triggered the payment.
    /// </summary>
    public PaymentInitiator PaymentInitiator { get; set; }

    /// <summary>
    /// Indicates the type of the stored payment_source payment.
    /// </summary>
    public PaymentType PaymentType { get; set; }

    /// <summary>
    /// Reference values used by the card network to identify a transaction.
    /// </summary>
    public NetworkTransactionReferenceDto PreviousNetworkTransactionReference { get; set; }

    /// <summary>
    /// Indicates if this is a <c>first</c> or <c>subsequent</c> payment using a stored payment source (also referred to as stored
    /// credential or card on file).
    /// </summary>
    public PaymentUsage Usage { get; set; }

    private void Validate()
    {
        if (PaymentInitiator is PaymentInitiator.None)
        {
            throw new PayPalModelValidationException<StoredPaymentSourceDto>("PaymentInitiator is required.");
        }

        if (PaymentType is PaymentType.None)
        {
            throw new PayPalModelValidationException<StoredPaymentSourceDto>("PaymentType is required.");
        }
    }

    internal StoredPaymentSource ToRequestModel()
    {
        Validate();

        return new StoredPaymentSource
        {
            PaymentInitiator = PaymentInitiator.GetStringValue(),
            PaymentType = PaymentType.GetStringValue(),
            PreviousNetworkTransactionReference = PreviousNetworkTransactionReference?.ToRequestModel(),
            Usage = Usage.GetStringValue()
        };
    }
}
