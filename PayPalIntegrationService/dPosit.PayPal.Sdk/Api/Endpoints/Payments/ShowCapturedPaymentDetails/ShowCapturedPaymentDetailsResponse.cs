using System.Text.Json.Serialization;
using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Api.Endpoints.Payments.ShowCapturedPaymentDetails;

internal sealed class ShowCapturedPaymentDetailsResponse
{
    /// <summary>
    /// An object that provides supplementary/additional data related to a payment transaction.
    /// </summary>
    [JsonPropertyName("supplementary_data")]
    public SupplementaryData SupplementaryData { get; set; }
}
