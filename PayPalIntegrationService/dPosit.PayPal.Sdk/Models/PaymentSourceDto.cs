using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class PaymentSourceDto
{
    /// <summary>
    /// The tokenized payment source to fund a payment.
    /// </summary>
    public TokenDto Token { get; set; }

    internal PaymentSource ToRequestModel()
    {
        return new PaymentSource
        {
            Token = Token?.ToRequestModel()
        };
    }
}
