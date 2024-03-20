using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class ApplicationContextDto
{
    /// <summary>
    /// The label that overrides the business name in the PayPal account on the PayPal site.
    /// </summary>
    public string BrandName { get; set; }

    /// <summary>
    /// The URL where the customer is redirected after the customer cancels the payment.
    /// </summary>
    public string CancelUrl { get; set; }

    /// <summary>
    /// The locale of pages that the PayPal payment experience shows.
    /// </summary>
    public Locale Locale { get; set; }

    /// <summary>
    /// The customer and merchant payment preferences.
    /// </summary>
    public PaymentMethodDto PaymentMethod { get; set; }

    /// <summary>
    /// The URL where the customer is redirected after the customer approves the payment.
    /// </summary>
    public string ReturnUrl { get; set; }

    /// <summary>
    /// Configures a <b>Continue</b> or <b>Pay Now</b> checkout flow.
    /// </summary>
    public UserCheckoutAction UserAction { get; set; }

    private void Validate()
    {
        if (BrandName is not null && BrandName.Length > 128)
        {
            throw new PayPalModelValidationException<ApplicationContextDto>("Incorrect BrandName lenght.");
        }
    }

    internal ApplicationContext ToRequestModel()
    {
        Validate();

        return new ApplicationContext
        {
            BrandName = BrandName,
            CancelUrl = CancelUrl,
            Locale = Locale.GetStringValue(),
            PaymentMethod = PaymentMethod?.ToRequestModel(),
            ReturnUrl = ReturnUrl,
            UserAction = UserAction.GetStringValue()
        };
    }
}
