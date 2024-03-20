namespace dPosit.PayPal.Sdk.Models;

public enum TaxIdType
{
    /// <summary>
    /// Default empty value
    /// </summary>
    None,
    /// <summary>
    /// The individual tax ID type, typically is 11 characters long.
    /// </summary>
    BrCpf,
    /// <summary>
    /// The business tax ID type, typically is 14 characters long.
    /// </summary>
    BrCnpj
}
