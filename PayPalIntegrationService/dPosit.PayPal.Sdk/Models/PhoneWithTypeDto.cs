namespace dPosit.PayPal.Sdk.Models;

public sealed class PhoneWithTypeDto
{
    /// <summary>
    /// The phone number, in its canonical international E.164 numbering plan format. Supports only the <c>national_number</c> property.
    /// </summary>
    public PhoneNumberDto PhoneNumber { get; set; }

    /// <summary>
    /// The phone type.
    /// </summary>
    public PhoneType PhoneType { get; set; }
}
