using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class OrderConfirmApplicationContextDto
{
    /// <summary>
    /// Label to present to your payer as part of the PayPal hosted web experience.
    /// </summary>
    public string BrandName { get; set; }

    /// <summary>
    /// The URL where the customer is redirected after the customer cancels the payment.
    /// </summary>
    public string CancelUrl { get; set; }

    /// <summary>
    /// The BCP 47-formatted locale of pages that the PayPal payment experience shows. PayPal supports a five-character code.
    /// </summary>
    public Locale Locale { get; set; }

    /// <summary>
    /// The URL where the customer is redirected after the customer approves the payment.
    /// </summary>
    public string ReturnUrl { get; set; }

    /// <summary>
    /// Provides additional details to process a payment using a <c>payment_source</c> that has been stored or is intended to be stored
    /// (also referred to as stored_credential or card-on-file).
    /// </summary>
    /// <remarks>
    /// Parameter compatibility:<br/>
    /// <see cref="PaymentType.OneTime"/> is compatible only with <see cref="PaymentInitiator.Customer"/>.<br/>
    /// <see cref="PaymentUsage.First"/> is compatible only with <see cref="PaymentInitiator.Customer"/>.<br/>
    /// <see cref="StoredPaymentSourceDto.PreviousNetworkTransactionReference"/> is compatible only with
    /// <see cref="PaymentInitiator.Merchant"/>.<br/>
    /// </remarks>
    public StoredPaymentSourceDto StoredPaymentSource { get; set; }

    private void Validate()
    {
        if (BrandName is not null && BrandName.Length > 127)
        {
            throw new PayPalModelValidationException<OrderConfirmApplicationContextDto>("Incorrect BrandName lenght.");
        }

        if (CancelUrl is not null && (CancelUrl.Length < 10 || CancelUrl.Length > 4000))
        {
            throw new PayPalModelValidationException<OrderConfirmApplicationContextDto>("Incorrect CancelUrl lenght.");
        }

        if (ReturnUrl is not null && (ReturnUrl.Length < 10 || ReturnUrl.Length > 4000))
        {
            throw new PayPalModelValidationException<OrderConfirmApplicationContextDto>("Incorrect ReturnUrl lenght.");
        }
    }

    internal OrderConfirmApplicationContext ToRequestModel()
    {
        Validate();

        return new OrderConfirmApplicationContext
        {
            BrandName = BrandName,
            CancelUrl = CancelUrl,
            Locale = Locale.GetStringValue(),
            ReturnUrl = ReturnUrl,
            StoredPaymentSource = StoredPaymentSource?.ToRequestModel()
        };
    }
}
