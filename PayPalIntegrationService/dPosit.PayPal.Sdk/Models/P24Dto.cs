using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class P24Dto
{
    /// <summary>
    /// The country or region.
    /// </summary>
    public Country Country { get; set; }

    /// <summary>
    /// The email address of the account holder associated with this payment method.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Friendly name of the payment scheme or bank used for the payment.
    /// </summary>
    public string MethodDescription { get; set; }

    /// <summary>
    /// Numeric identifier of the payment scheme or bank used for the payment.
    /// </summary>
    public string MethodId { get; set; }

    /// <summary>
    /// The name of the account holder associated with this payment method.
    /// </summary>
    public NameDto Name { get; set; }

    /// <summary>
    /// P24 generated payment description.
    /// </summary>
    public string PaymentDescriptor { get; set; }

    internal static P24Dto CreateFromModel(P24 model)
    {
        if (model is null)
        {
            return null;
        }

        return new P24Dto
        {
            Country = Helpers.ParseCountryCodeValue(model.CountryCode),
            Email = model.Email,
            MethodDescription = model.MethodDescription,
            MethodId = model.MethodId,
            Name = NameDto.CreateFromModel(model.Name),
            PaymentDescriptor = model.PaymentDescriptor
        };
    }
}
