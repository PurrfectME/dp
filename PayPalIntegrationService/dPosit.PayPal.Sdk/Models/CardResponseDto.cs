using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class CardResponseDto
{
    /// <summary>
    /// Results of Authentication such as 3D Secure.
    /// </summary>
    public AuthenticationResponseDto AuthenticationResult { get; set; }

    /// <summary>
    /// The billing address for this card. Supports only the <c>address_line_1</c>, <c>address_line_2</c>, <c>admin_area_1</c>,
    /// <c>admin_area_2</c>, <c>postal_code</c>, and <c>country_code</c> properties.
    /// </summary>
    public AddressPortableDto BillingAddress { get; set; }

    /// <summary>
    /// The card brand or network. Typically used in the response.
    /// </summary>
    public CardBrand Brand { get; set; }

    /// <summary>
    /// The last digits of the payment card.
    /// </summary>
    public string LastDigits { get; set; }

    /// <summary>
    /// The card holder's name as it appears on the card.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The payment card type.
    /// </summary>
    public PaymentCardType Type { get; set; }

    internal static CardResponseDto CreateFromModel(CardResponse model)
    {
        if (model is null)
        {
            return null;
        }

        return new CardResponseDto
        {
            AuthenticationResult = AuthenticationResponseDto.CreateFromModel(model.AuthenticationResult),
            BillingAddress = AddressPortableDto.CreateFromModel(model.BillingAddress),
            Brand = Helpers.ParseCardBrandValue(model.Brand),
            LastDigits = model.LastDigits,
            Name = model.Name,
            Type = Helpers.ParsePaymentCardTypeValue(model.Type)
        };
    }
}
