using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class PaymentSourceResponse
{
    /// <summary>
    /// Information used to pay Bancontact.
    /// </summary>
    [JsonPropertyName("bancontact")]
    public Bancontact Bancontact { get; set; }

    /// <summary>
    /// Information used to pay using BLIK.
    /// </summary>
    [JsonPropertyName("blik")]
    public Blik Blik { get; set; }

    /// <summary>
    /// The payment card to use to fund a payment. Card can be a credit or debit card.
    /// </summary>
    [JsonPropertyName("card")]
    public CardResponse Card { get; set; }

    /// <summary>
    /// Information used to pay using eps.
    /// </summary>
    [JsonPropertyName("eps")]
    public Eps Eps { get; set; }

    /// <summary>
    /// Information needed to pay using giropay.
    /// </summary>
    [JsonPropertyName("giropay")]
    public Giropay Giropay { get; set; }

    /// <summary>
    /// Information used to pay using iDEAL.
    /// </summary>
    [JsonPropertyName("ideal")]
    public Ideal Ideal { get; set; }

    /// <summary>
    /// Information used to pay using MyBank.
    /// </summary>
    [JsonPropertyName("mybank")]
    public MyBank MyBank { get; set; }

    /// <summary>
    /// Information used to pay using P24 (Przelewy24).
    /// </summary>
    [JsonPropertyName("p24")]
    public P24 P24 { get; set; }

    /// <summary>
    /// Information used to pay using Sofort.
    /// </summary>
    [JsonPropertyName("sofort")]
    public Sofort Sofort { get; set; }

    /// <summary>
    /// Information needed to pay using Trustly.
    /// </summary>
    [JsonPropertyName("trustly")]
    public Trustly Trustly { get; set; }
}
