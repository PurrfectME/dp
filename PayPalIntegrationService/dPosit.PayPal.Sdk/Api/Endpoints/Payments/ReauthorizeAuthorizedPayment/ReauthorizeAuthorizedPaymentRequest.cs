using System.Text.Json.Serialization;
using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Api.Endpoints.Payments.ReauthorizeAuthorizedPayment;

internal sealed class ReauthorizeAuthorizedPaymentRequest : AuthorizedRequest
{
    /// <summary>
    /// The amount to reauthorize for an authorized payment.
    /// </summary>
    [JsonPropertyName("amount")]
    public Money Amount { get; set; }
}
