namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class Payee
{
    /// <summary>
    /// The email address of merchant.
    /// </summary>
    public string EmailAddress { get; set; }

    /// <summary>
    /// The encrypted PayPal account ID of the merchant.
    /// </summary>
    public string MerchantId { get; set; }
}
