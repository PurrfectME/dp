using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class TaxInfo
{
    /// <summary>
    /// The customer's tax ID value.
    /// </summary>
    [JsonPropertyName("tax_id")]
    public string TaxId { get; set; }

    /// <summary>
    /// The customer's tax ID type.
    /// </summary>
    /// <value>
    /// "BR_CPF" - the individual tax ID type, typically is 11 characters long.<br/>
    /// "BR_CNPJ" - the business tax ID type, typically is 14 characters long.
    /// </value>
    [JsonPropertyName("tax_id_type")]
    public string TaxIdType { get; set; }
}
