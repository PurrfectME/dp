namespace dPosit.PayPal.Sdk.Models;

public sealed class TaxInfoDto
{
    /// <summary>
    /// The customer's tax ID value.
    /// </summary>
    public string TaxId { get; set; }

    /// <summary>
    /// The customer's tax ID type.
    /// </summary>
    public TaxIdType TaxIdType { get; set; }
}
