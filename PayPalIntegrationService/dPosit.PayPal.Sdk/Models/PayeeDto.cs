using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Exceptions;

namespace dPosit.PayPal.Sdk.Models;

public class PayeeDto
{
    /// <summary>
    /// The email address of merchant.
    /// </summary>
    public string EmailAddress { get; set; }

    /// <summary>
    /// The encrypted PayPal account ID of the merchant.
    /// </summary>
    public string MerchantId { get; set; }

    private void Validate()
    {
        if (EmailAddress is not null)
        {
            // The generally accepted maximum length for an email address is 254 characters
            if (EmailAddress.Length > 254)
            {
                throw new PayPalModelValidationException<PayeeDto>("Incorrect EmailAddress lenght.");
            }

            // Up to 64 characters are allowed before and 255 characters are allowed after the '@' sign.
            if (!EmailAddress.Contains('@') || EmailAddress.Split('@')[0].Length > 64 || EmailAddress.Split('@')[1].Length > 255)
            {
                throw new PayPalModelValidationException<PayeeDto>("Incorrect EmailAddress format.");
            }
        }

        if (MerchantId is not null && MerchantId.Length != 13)
        {
            throw new PayPalModelValidationException<PayeeDto>("Incorrect MerchantId format.");
        }
    }

    internal Payee ToRequestModel()
    {
        Validate();

        return new Payee
        {
            EmailAddress = EmailAddress,
            MerchantId = MerchantId
        };
    }

    internal static PayeeDto CraeteFromModel(Payee model)
    {
        if (model is null)
        {
            return null;
        }

        return new PayeeDto
        {
            EmailAddress = model.EmailAddress,
            MerchantId = model.MerchantId
        };
    }
}
