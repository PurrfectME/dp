using dPosit.PayPal.Sdk.Exceptions;

namespace dPosit.PayPal.Sdk.RequestModels;

public abstract class AuthorizedRequestDto<T>
{
    /// <summary>
    /// Jwt access token.
    /// </summary>
    public string Jwt { get; set; }

    protected virtual void Validate()
    {
        if (string.IsNullOrWhiteSpace(Jwt))
        {
            throw new PayPalModelValidationException<T>("Jwt is required.");
        }
    }
}
