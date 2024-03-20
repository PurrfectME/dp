using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class TokenDto
{
    /// <summary>
    /// The PayPal-generated ID for the token.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// The tokenization method that generated the ID.
    /// </summary>
    public TokenizationMethod Type { get; set; }

    private void Validate()
    {
        if (string.IsNullOrWhiteSpace(Id))
        {
            throw new PayPalModelValidationException<TokenDto>("Id is required.");
        }

        if (Id.Length > 255)
        {
            throw new PayPalModelValidationException<TokenDto>("Incorrect Id lenght.");
        }

        if (Type is TokenizationMethod.None)
        {
            throw new PayPalModelValidationException<TokenDto>("Type is required.");

        }
    }

    internal Token ToRequestModel()
    {
        Validate();

        return new Token
        {
            Id = Id,
            Type = Type.GetStringValue()
        };
    }
}
