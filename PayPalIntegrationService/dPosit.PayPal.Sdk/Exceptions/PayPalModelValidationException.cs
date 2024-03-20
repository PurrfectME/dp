namespace dPosit.PayPal.Sdk.Exceptions;

public class PayPalModelValidationException<T> : PayPalModelValidationException
{
    public PayPalModelValidationException(string message = "") : base($"Incorrect validation of {typeof(T)} model. {message}")
    {
    }
}

// Since it is not possible to catch generic exceptions, we need to catch any PayPalModelValidationException<T> with non-generic one
public class PayPalModelValidationException : Exception
{
    protected PayPalModelValidationException(string message) : base(message)
    {
    }
}
