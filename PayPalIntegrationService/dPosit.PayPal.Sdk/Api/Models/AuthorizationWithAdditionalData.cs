using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class AuthorizationWithAdditionalData
{
    /// <summary>
    /// The processor response for card transactions.
    /// </summary>
    [JsonPropertyName("processor_response")]
    public ProcessorResponse ProcessorResponse { get; set; }
}
