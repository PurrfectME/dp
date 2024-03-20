using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class NetworkTransactionReference
{
    /// <summary>
    /// Transaction reference id returned by the scheme. For Visa and Amex, this is the "Tran id" field in response. For MasterCard, this
    /// is the "BankNet reference id" field in response. For Discover, this is the "NRID" field in response.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Name of the card network through which the transaction was routed.
    /// </summary>
    /// <value>
    /// "VISA" - Visa card.<br/>
    /// "MASTERCARD" - Mastecard card.<br/>
    /// "DISCOVER" - Discover card.<br/>
    /// "AMEX" - American Express card.<br/>
    /// "SOLO" - Solo debit card.<br/>
    /// "JCB" - Japan Credit Bureau card.<br/>
    /// "STAR" - Military Star card.<br/>
    /// "DELTA" - Delta Airlines card.<br/>
    /// "SWITCH" - Switch credit card.<br/>
    /// "MAESTRO" - Maestro credit card.<br/>
    /// "CB_NATIONALE" - Carte Bancaire (CB) credit card.<br/>
    /// "CONFIGOGA" - Configoga credit card.<br/>
    /// "CONFIDIS" - Confidis credit card.<br/>
    /// "ELECTRON" - Visa Electron credit card.<br/>
    /// "CETELEM" - Cetelem credit card.<br/>
    /// "CHINA_UNION_PAY" - China union pay credit card.
    /// </value>
    [JsonPropertyName("network")]
    public string Network { get; set; }

    /// <summary>
    /// The date that the transaction was authorized by the scheme. For MasterCard, this is the "BankNet reference date" field in response.
    /// </summary>
    [JsonPropertyName("date")]
    public string Date { get; set; }
}
